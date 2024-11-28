using TD.KCN.WebApi.Application.Identity.Roles;

namespace TD.KCN.WebApi.Host.Controllers.Identity;

public class RolesController : VersionNeutralApiController
{
    private readonly IRoleService _roleService;

    public RolesController(IRoleService roleService) => _roleService = roleService;

    [HttpPost("search")]
    [OpenApiOperation("Danh sách vai trò.", "")]
    public Task<PaginationResponse<RoleDetailsDto>> SearchAsync(RoleListFilter filter, CancellationToken cancellationToken)
    {
        return _roleService.SearchAsync(filter, cancellationToken);
    }

    [HttpGet]
    [MustHavePermission(TDAction.Manage, TDResource.Roles)]
    [OpenApiOperation("Get a list of all roles.", "")]
    public Task<List<RoleDto>> GetListAsync(CancellationToken cancellationToken)
    {
        return _roleService.GetListAsync(cancellationToken);
    }

    [HttpGet("{id}")]
    [MustHavePermission(TDAction.Manage, TDResource.Roles)]
    [OpenApiOperation("Get role details.", "")]
    public Task<RoleDto> GetByIdAsync(string id)
    {
        return _roleService.GetByIdAsync(id);
    }

    [HttpGet("{id}/permissions/group")]
    [MustHavePermission(TDAction.Manage, TDResource.RoleClaims)]
    [OpenApiOperation("Get role details with its permissions.", "")]
    public Task<RoleWithPermissionGroupsDto> GetByIdWithPermissionGroupsAsync(string id, CancellationToken cancellationToken)
    {
        return _roleService.GetByIdWithPermissionGroupsAsync(id, cancellationToken);
    }

    [HttpGet("{id}/permissions")]
    [MustHavePermission(TDAction.Manage, TDResource.RoleClaims)]
    [OpenApiOperation("Get role details with its permissions.", "")]
    public Task<RoleDto> GetByIdWithPermissionsAsync(string id, CancellationToken cancellationToken)
    {
        return _roleService.GetByIdWithPermissionsAsync(id, cancellationToken);
    }

    [HttpPut("{id}/permissions")]
    [MustHavePermission(TDAction.Manage, TDResource.RoleClaims)]
    [OpenApiOperation("Update a role's permissions.", "")]
    public async Task<ActionResult<string>> UpdatePermissionsAsync(string id, UpdateRolePermissionsRequest request, CancellationToken cancellationToken)
    {
        if (id != request.RoleId)
        {
            return BadRequest();
        }

        return Ok(await _roleService.UpdatePermissionsAsync(request, cancellationToken));
    }

    [HttpPost]
    [MustHavePermission(TDAction.Manage, TDResource.Roles)]
    [OpenApiOperation("Create or update a role.", "")]
    public Task<string> RegisterRoleAsync(CreateOrUpdateRoleRequest request, CancellationToken cancellationToken)
    {
        return _roleService.CreateOrUpdateAsync(request, cancellationToken);
    }

    [HttpDelete("{id}")]
    [MustHavePermission(TDAction.Manage, TDResource.Roles)]
    [OpenApiOperation("Delete a role.", "")]
    public Task<string> DeleteAsync(string id)
    {
        return _roleService.DeleteAsync(id);
    }
}