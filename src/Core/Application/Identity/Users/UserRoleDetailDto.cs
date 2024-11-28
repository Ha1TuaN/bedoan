using TD.KCN.WebApi.Application.Identity.Roles;

namespace TD.KCN.WebApi.Application.Identity.Users;

public class UserRoleDetailDto
{
    public string Username { get; set; } = default!;
    public string RoleId { get; set; } = default!;
}