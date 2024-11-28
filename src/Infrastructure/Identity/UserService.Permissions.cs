using TD.KCN.WebApi.Application.Common.Caching;
using TD.KCN.WebApi.Application.Common.Exceptions;
using TD.KCN.WebApi.Shared.Authorization;
using Microsoft.EntityFrameworkCore;
using TD.KCN.WebApi.Application.Identity.Users;
using Microsoft.AspNetCore.Identity;
using TD.KCN.WebApi.Shared.Multitenancy;
using Namotion.Reflection;

namespace TD.KCN.WebApi.Infrastructure.Identity;

internal partial class UserService
{
    public async Task<List<string>> GetPermissionsAsync(string userId, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByIdAsync(userId);

        _ = user ?? throw new UnauthorizedException("Authentication Failed.");

        var userRoles = await _userManager.GetRolesAsync(user);
        var permissions = new List<string>();
        foreach (var role in await _roleManager.Roles
            .Where(r => userRoles.Contains(r.Name!))
            .ToListAsync(cancellationToken))
        {
            permissions.AddRange(await _db.RoleClaims
                .Where(rc => rc.RoleId == role.Id && rc.ClaimType == TDClaims.Permission)
                .Select(rc => rc.ClaimValue!)
                .ToListAsync(cancellationToken));
        }

        return permissions.Distinct().ToList();
    }

    public async Task<UserPermissionDto> GetByUserNameWithPermissionsAsync(string userName, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByNameAsync(userName);
        _ = user ?? throw new NotFoundException(_t["User Not Found."]);

        var permissions = new List<string>();

        var tmp = new UserPermissionDto();
#pragma warning disable CS8601 // Possible null reference assignment.
        tmp.UserName = user.UserName;
#pragma warning restore CS8601 // Possible null reference assignment.

#pragma warning disable CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
        permissions.AddRange(await _db.UserClaims
               .Where(rc => rc.UserId == user.Id && rc.ClaimType == TDClaims.Permission)
               .Select(rc => rc.ClaimValue)
               .ToListAsync(cancellationToken));
#pragma warning restore CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.

        tmp.Permissions = permissions;
        return tmp;
    }

    public async Task<string> UpdatePermissionsAsync(UpdateUserPermissionsRequest request, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByNameAsync(request.UserName);
        _ = user ?? throw new NotFoundException(_t["User Not Found."]);

        if (request.Permissions == null)
        {
            return _t["Permissions Updated."];
        }

        if (_currentTenant.Id != MultitenancyConstants.Root.Id)
        {
            // Remove Root Permissions if the Role is not created for Root Tenant.
            request.Permissions.RemoveAll(u => u.StartsWith("Permissions.Root."));
        }

        var currentClaims = await _userManager.GetClaimsAsync(user);
        foreach (var claim in currentClaims.Where(c =>
            !request.Permissions.Any(p => p == c.Value)))
        {
            var removeResult = await _userManager.RemoveClaimAsync(user, claim);
            if (!removeResult.Succeeded)
            {
                throw new InternalServerException(_t["Update permissions failed."], removeResult.GetErrors(_t));
            }
        }

        string? roleId = await _db.UserRoles
            .Where(x => x.UserId.ToLower() == user.Id.ToLower())
            .Select(x => x.RoleId)
            .FirstOrDefaultAsync();

        var claimsByRole = await _db.RoleClaims
            .Where(x => x.RoleId == roleId)
            .Select(x => x.ClaimValue)
            .ToListAsync();

        foreach (string permission in request.Permissions.Where(c => !currentClaims.Any(p => p.Value == c) &&
         claimsByRole.All(p => p != c)))
        {
            if (!string.IsNullOrEmpty(permission))
            {
                _db.UserClaims.Add(new IdentityUserClaim<string>
                {
                    UserId = user.Id,
                    ClaimType = TDClaims.Permission,
                    ClaimValue = permission,
                });
                await _db.SaveChangesAsync(cancellationToken);
            }
        }

        return _t["Permissions Updated."];
    }

    public async Task<bool> HasPermissionAsync(string userId, string permission, CancellationToken cancellationToken)
    {
        var permissions = await _cache.GetOrSetAsync(
            _cacheKeys.GetCacheKey(TDClaims.Permission, userId),
            () => GetPermissionsAsync(userId, cancellationToken),
            cancellationToken: cancellationToken);

        return permissions?.Contains(permission) ?? false;
    }

    public Task InvalidatePermissionCacheAsync(string userId, CancellationToken cancellationToken) =>
        _cache.RemoveAsync(_cacheKeys.GetCacheKey(TDClaims.Permission, userId), cancellationToken);
}