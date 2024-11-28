namespace TD.KCN.WebApi.Application.Identity.Permissions;

public interface IPermissionService : ITransientService
{
    List<PermissionDto> GetAllPermissions();
    List<PermissionGroupDto> GetAllPermissionGroups();

}