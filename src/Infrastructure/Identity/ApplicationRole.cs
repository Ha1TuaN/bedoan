using Microsoft.AspNetCore.Identity;

namespace TD.KCN.WebApi.Infrastructure.Identity;

public class ApplicationRole : IdentityRole
{
    public string? Description { get; set; }
    public bool? IsSystem { get; set; }

    public ApplicationRole(string name, string? description = null, bool? isSystem = false)
        : base(name)
    {
        Description = description;
        IsSystem = isSystem;
        NormalizedName = name.ToUpperInvariant();
    }
}