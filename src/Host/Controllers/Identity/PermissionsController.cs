using TD.KCN.WebApi.Application.Identity.Permissions;
namespace TD.KCN.WebApi.Host.Controllers.Identity;

public sealed class PermissionsController : VersionNeutralApiController
{
    private readonly IPermissionService _permissionService;

    public PermissionsController(IPermissionService permissionService) => _permissionService = permissionService;

    // [MustHavePermission(TDAction.View, TDResource.Roles)]
    [HttpGet]
    [OpenApiOperation("Get a list of all permissions.", "")]
    public List<PermissionDto> GetAllPermissions()
    {
        return _permissionService.GetAllPermissions();
    }

    // [MustHavePermission(TDAction.View, TDResource.Roles)]
    [HttpGet("group")]
    [OpenApiOperation("Get a list of all permission groups.", "")]
    public List<PermissionGroupDto> GetAllPermissionGroups()
    {
        return _permissionService.GetAllPermissionGroups();
    }

}