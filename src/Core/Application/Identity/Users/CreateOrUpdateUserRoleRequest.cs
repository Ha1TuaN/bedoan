using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.KCN.WebApi.Application.Identity.Permissions;
using TD.KCN.WebApi.Application.Identity.Roles;

namespace TD.KCN.WebApi.Application.Identity.Users;
public class CreateOrUpdateUserRoleRequest
{
    public string UserId { get; set; } = default!;
    public string RoleId { get; set; } = default!;
}
