using Microsoft.AspNetCore.Identity;
using TD.KCN.WebApi.Domain.Catalog;
using TD.KCN.WebApi.Domain.House;

namespace TD.KCN.WebApi.Infrastructure.Identity;

public class ApplicationUser : IdentityUser
{
    public string? FullName { get; set; }
    public string? Address { get; set; }
    public string? ImageUrl { get; set; }
    public DateTime? CreatedOn { get; set; }
    public Guid? MotelId { get; set; }
}