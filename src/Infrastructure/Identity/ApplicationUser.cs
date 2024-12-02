using Microsoft.AspNetCore.Identity;
using TD.KCN.WebApi.Domain.Catalog;
using TD.KCN.WebApi.Domain.House;

namespace TD.KCN.WebApi.Infrastructure.Identity;

public class ApplicationUser : IdentityUser
{
    public string? FullName { get; set; }
    public string? Gender { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Address { get; set; }
    public string? ImageUrl { get; set; }
    public bool IsActive { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }
    public string? ObjectId { get; set; }
    public int? Type { get; set; }
    public string? Status { get; set; }
    public DateTime? CreatedOn { get; set; }
}