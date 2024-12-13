using TD.KCN.WebApi.Application.Identity.Users;
using TD.KCN.WebApi.Application.Identity.Users.Password;

namespace TD.KCN.WebApi.Host.Controllers.Identity;

public class UsersController : VersionNeutralApiController
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService) => _userService = userService;

    [HttpPost("search")]
    [AllowAnonymous]
    [OpenApiOperation("Search list of all users..", "")]
    public Task<PaginationResponse<UserDetailsDto>> SearchAsync(UserListFilter request, CancellationToken cancellationToken)
    {
        return _userService.SearchAsync(request, cancellationToken);
    }

    [HttpGet("currentuser")]
    [OpenApiOperation("Get a user's details.", "")]
    public Task<UserDetailsDto> GetCurrentUserAsync(CancellationToken cancellationToken)
    {
        return _userService.GetCurrentUserAsync(cancellationToken);
    }

    [HttpGet]
    [AllowAnonymous]
    [OpenApiOperation("Get list of all users.", "")]
    public Task<List<UserDetailsDto>> GetListAsync(CancellationToken cancellationToken)
    {
        return _userService.GetListAsync(cancellationToken);
    }

    [HttpGet("{id}")]
    [AllowAnonymous]
    [OpenApiOperation("Get a user's details.", "")]
    public Task<UserDetailsDto> GetByIdAsync(string id, CancellationToken cancellationToken)
    {
        return _userService.GetAsync(id, cancellationToken);
    }

    [HttpGet("{id}/roles")]
    [MustHavePermission(TDAction.Manage, TDResource.Roles)]
    [OpenApiOperation("Get a user's roles.", "")]
    public Task<List<UserRoleDto>> GetRolesAsync(string id, CancellationToken cancellationToken)
    {
        return _userService.GetRolesAsync(id, cancellationToken);
    }

    [HttpGet("roles/{username}")]
    [MustHavePermission(TDAction.Manage, TDResource.Roles)]
    [OpenApiOperation("Get a user's roles.", "")]
    public Task<UserRoleDetailDto> GetRolesByUserNameAsync(string username, CancellationToken cancellationToken)
    {
        return _userService.GetRolesByUserNameAsync(username, cancellationToken);
    }

    [HttpGet("permissions/{username}")]
    [MustHavePermission(TDAction.Manage, TDResource.Roles)]
    [OpenApiOperation("Get a user's roles.", "")]
    public Task<UserPermissionDto> GetPermissionsByUserNameAsync(string username, CancellationToken cancellationToken)
    {
        return _userService.GetPermissionsByUserNameAsync(username, cancellationToken);
    }

    [HttpPost("{id}/roles")]
    [ApiConventionMethod(typeof(TDApiConventions), nameof(TDApiConventions.Register))]
    [MustHavePermission(TDAction.Manage, TDResource.Roles)]
    [OpenApiOperation("Update a user's assigned roles.", "")]
    public Task<string> AssignRolesAsync(string id, UserRolesRequest request, CancellationToken cancellationToken)
    {
        return _userService.AssignRolesAsync(id, request, cancellationToken);
    }

    [HttpPost("CreateOrUpdateUserRoles")]
    [MustHavePermission(TDAction.Manage, TDResource.Roles)]
    [OpenApiOperation("Update a user's assigned roles.", "")]
    public Task<string> CreateOrUpdateUserRolesAsync(CreateOrUpdateUserRoleRequest request, CancellationToken cancellationToken)
    {
        return _userService.CreateOrUpdateUserRoleAsync(request, cancellationToken);
    }

    [HttpPost]
    [OpenApiOperation("Creates a new user.", "")]
    [AllowAnonymous]
    public Task<string> CreateAsync(CreateUserRequest request)
    {
        return _userService.CreateAsync(request, GetOriginFromRequest());
    }

    [HttpPost("self-register")]
    [TenantIdHeader]
    [AllowAnonymous]
    [OpenApiOperation("Anonymous user creates a user.", "")]
    [ApiConventionMethod(typeof(TDApiConventions), nameof(TDApiConventions.Register))]
    public Task<string> SelfRegisterAsync(CreateUserRequest request)
    {
        return _userService.CreateAsync(request, GetOriginFromRequest());
    }

    [HttpPost("{id}/toggle-status")]
    [MustHavePermission(TDAction.Manage, TDResource.Users)]
    [ApiConventionMethod(typeof(TDApiConventions), nameof(TDApiConventions.Register))]
    [OpenApiOperation("Toggle a user's active status.", "")]
    public async Task<ActionResult> ToggleStatusAsync(string id, ToggleUserStatusRequest request, CancellationToken cancellationToken)
    {
        if (id != request.UserId)
        {
            return BadRequest();
        }

        await _userService.ToggleStatusAsync(request, cancellationToken);
        return Ok();
    }

    [HttpGet("confirm-email")]
    [AllowAnonymous]
    [OpenApiOperation("Confirm email address for a user.", "")]
    [ApiConventionMethod(typeof(TDApiConventions), nameof(TDApiConventions.Search))]
    public Task<string> ConfirmEmailAsync([FromQuery] string tenant, [FromQuery] string userId, [FromQuery] string code, CancellationToken cancellationToken)
    {
        return _userService.ConfirmEmailAsync(userId, code, tenant, cancellationToken);
    }

    [HttpGet("confirm-phone-number")]
    [AllowAnonymous]
    [OpenApiOperation("Confirm phone number for a user.", "")]
    [ApiConventionMethod(typeof(TDApiConventions), nameof(TDApiConventions.Search))]
    public Task<string> ConfirmPhoneNumberAsync([FromQuery] string userId, [FromQuery] string code)
    {
        return _userService.ConfirmPhoneNumberAsync(userId, code);
    }

    [HttpPost("forgot-password")]
    [AllowAnonymous]
    [TenantIdHeader]
    [OpenApiOperation("Request a password reset email for a user.", "")]
    [ApiConventionMethod(typeof(TDApiConventions), nameof(TDApiConventions.Register))]
    public Task<string> ForgotPasswordAsync(ForgotPasswordRequest request)
    {
        return _userService.ForgotPasswordAsync(request, GetOriginFromRequest());
    }

    [HttpPost("reset-password")]
    [OpenApiOperation("Reset a user's password.", "")]
    [ApiConventionMethod(typeof(TDApiConventions), nameof(TDApiConventions.Register))]
    public Task<string> ResetPasswordAsync(ResetPasswordRequest request)
    {
        return _userService.ResetPasswordAsync(request);
    }

    [HttpGet("{username}/permissions")]
    [OpenApiOperation("Get role details with its permissions.", "")]
    public Task<UserPermissionDto> GetByIdWithPermissionsAsync(string username, CancellationToken cancellationToken)
    {
        return _userService.GetByUserNameWithPermissionsAsync(username, cancellationToken);
    }

    [HttpPut("{username}/permissions")]
    [OpenApiOperation("Update a role's permissions.", "")]
    public async Task<ActionResult<string>> UpdatePermissionsAsync(string username, UpdateUserPermissionsRequest request, CancellationToken cancellationToken)
    {
        if (username != request.UserName)
        {
            return BadRequest();
        }

        return Ok(await _userService.UpdatePermissionsAsync(request, cancellationToken));
    }

    private string GetOriginFromRequest() => $"{Request.Scheme}://{Request.Host.Value}{Request.PathBase.Value}";

    [HttpDelete("{id}")]
    [AllowAnonymous]
    [OpenApiOperation("Delete a user.", "")]
    public async Task<bool> DeleteByUserNameAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _userService.DeleteUserAsync(id.ToString(), cancellationToken);
    }

    [HttpPut("{id}")]
    [OpenApiOperation("Edit user.", "")]
    public Task<bool> UpdateUserByIdAsync(string id, UpdateUserRequest request)
    {
        return _userService.UpdateByUserIdAsync(request, id);
    }
}
