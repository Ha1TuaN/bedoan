using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD.KCN.WebApi.Application.Identity.Users;
public class UserPermissionDto
{
    public string UserName { get; set; } = default!;
    public List<string>? Permissions { get; set; }
}
