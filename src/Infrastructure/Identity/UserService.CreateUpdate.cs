using System.Security.Claims;
using TD.KCN.WebApi.Application.Common.Exceptions;
using TD.KCN.WebApi.Application.Common.Mailing;
using TD.KCN.WebApi.Application.Identity.Users;
using TD.KCN.WebApi.Domain.Common;
using TD.KCN.WebApi.Domain.Identity;
using TD.KCN.WebApi.Shared.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using TD.KCN.WebApi.Domain.Catalog;
using TD.KCN.WebApi.Application.Common;
using System.Transactions;

namespace TD.KCN.WebApi.Infrastructure.Identity;

internal partial class UserService
{
    /// <summary>
    /// This is used when authenticating with AzureAd.
    /// The local user is retrieved using the objectidentifier claim present in the ClaimsPrincipal.
    /// If no such claim is found, an InternalServerException is thrown.
    /// If no user is found with that ObjectId, a new one is created and populated with the values from the ClaimsPrincipal.
    /// If a role claim is present in the principal, and the user is not yet in that roll, then the user is added to that role.
    /// </summary>
    public async Task<string> GetOrCreateFromPrincipalAsync(ClaimsPrincipal principal)
    {
        string? objectId = principal.GetObjectId();
        if (string.IsNullOrWhiteSpace(objectId))
        {
            throw new InternalServerException(_t["Invalid objectId"]);
        }

        var user = await _userManager.Users.Where(u => u.ObjectId == objectId).FirstOrDefaultAsync()
            ?? await CreateOrUpdateFromPrincipalAsync(principal);

        if (principal.FindFirstValue(ClaimTypes.Role) is string role &&
            await _roleManager.RoleExistsAsync(role) &&
            !await _userManager.IsInRoleAsync(user, role))
        {
            await _userManager.AddToRoleAsync(user, role);
        }

        return user.Id;
    }

    private async Task<ApplicationUser> CreateOrUpdateFromPrincipalAsync(ClaimsPrincipal principal)
    {
        string? email = principal.FindFirstValue(ClaimTypes.Upn);
        string? username = principal.GetDisplayName();
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username))
        {
            throw new InternalServerException(string.Format(_t["Username or Email not valid."]));
        }

        var user = await _userManager.FindByNameAsync(username);
        if (user is not null && !string.IsNullOrWhiteSpace(user.ObjectId))
        {
            throw new InternalServerException(string.Format(_t["Username {0} is already taken."], username));
        }

        if (user is null)
        {
            user = await _userManager.FindByEmailAsync(email);
            if (user is not null && !string.IsNullOrWhiteSpace(user.ObjectId))
            {
                throw new InternalServerException(string.Format(_t["Email {0} is already taken."], email));
            }
        }

        IdentityResult? result;
        if (user is not null)
        {
            user.ObjectId = principal.GetObjectId();
            result = await _userManager.UpdateAsync(user);

            await _events.PublishAsync(new ApplicationUserUpdatedEvent(user.Id));
        }
        else
        {
            user = new ApplicationUser
            {
                ObjectId = principal.GetObjectId(),
                Email = email,
                NormalizedEmail = email.ToUpperInvariant(),
                UserName = username,
                NormalizedUserName = username.ToUpperInvariant(),
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                IsActive = true
            };
            result = await _userManager.CreateAsync(user);

            await _events.PublishAsync(new ApplicationUserCreatedEvent(user.Id));
        }

        if (!result.Succeeded)
        {
            throw new InternalServerException(_t["Validation Errors Occurred."], result.GetErrors(_t));
        }

        return user;
    }

    public async Task<string> CreateAsync(CreateUserRequest request, string origin)
    {
        using (var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
        {
            try
            {
                var user = new ApplicationUser
                {
                    FullName = request.FullName,
                    Gender = request.Gender,
                    DateOfBirth = request.DateOfBirth,
                    Address = request.Address,
                    ImageUrl = "https://phunuvietnam.mediacdn.vn/media/news/33abffcedac43a654ac7f501856bf700/anh-profile-tiet-lo-g-ve-ban-1.jpg",
                    Email = request.Email,
                    PhoneNumber = request.PhoneNumber,
                    UserName = request.UserName,
                    IsActive = true,
                    Type = request.Type,
                    Status = request.Status,
                };
                var result = await _userManager.CreateAsync(user, request.Password);
                if (!result.Succeeded)
                {
                    throw new InternalServerException(_t["Validation Errors Occurred."], result.GetErrors(_t));
                }
                var messages = new List<string> { string.Format(_t["User {0} Registered."], user.UserName) };

                if (_securitySettings.RequireConfirmedAccount && !string.IsNullOrEmpty(user.Email))
                {
                    // send verification email
                    string emailVerificationUri = await GetEmailVerificationUriAsync(user, origin);
                    RegisterUserEmailModel eMailModel = new RegisterUserEmailModel()
                    {
                        Email = user.Email,
                        UserName = user.UserName,
                        Url = emailVerificationUri
                    };
                    var mailRequest = new MailRequest(
                        new List<string> { user.Email },
                        _t["Confirm Registration"],
                        _templateService.GenerateEmailTemplate("email-confirmation", eMailModel));
                    _jobService.Enqueue(() => _mailService.SendAsync(mailRequest, CancellationToken.None));
                    messages.Add(_t[$"Please check {user.Email} to verify your account!"]);
                }

                await _events.PublishAsync(new ApplicationUserCreatedEvent(user.Id));

                transactionScope.Complete();
                return string.Join(Environment.NewLine, messages);
            }
            catch (Exception ex)
            {
                throw new InternalServerException(_t[ex.Message]);
            }
        }
    }

    public async Task UpdateAsync(UpdateUserRequest request, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);

        _ = user ?? throw new NotFoundException(_t["User Not Found."]);

        user.FullName = request.FullName;
        user.Gender = request.Gender;
        user.DateOfBirth = request.DateOfBirth;
        user.Address = request.Address;
        user.ImageUrl = request.ImageUrl;
        user.Email = request.Email;
        user.PhoneNumber = request.PhoneNumber;
        user.Type = request.Type;
        user.Status = request.Status;
        string? phoneNumber = await _userManager.GetPhoneNumberAsync(user);
        if (request.PhoneNumber != phoneNumber)
        {
            await _userManager.SetPhoneNumberAsync(user, request.PhoneNumber);
        }

        var result = await _userManager.UpdateAsync(user);

        await _signInManager.RefreshSignInAsync(user);

        await _events.PublishAsync(new ApplicationUserUpdatedEvent(user.Id));

        if (!result.Succeeded)
        {
            throw new InternalServerException(_t["Update profile failed"], result.GetErrors(_t));
        }
    }
}
