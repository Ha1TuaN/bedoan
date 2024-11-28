namespace TD.KCN.WebApi.Application.Identity.Users;

public class UserDetailsDto
{
    public Guid Id { get; set; }
    public string? FullName { get; set; }
    public string? UserName { get; set; }
    public string? Gender { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Address { get; set; }
    public string? Email { get; set; }
    public bool IsActive { get; set; } = true;
    public bool EmailConfirmed { get; set; }
    public string? PhoneNumber { get; set; }
    public string? ImageUrl { get; set; }
    public List<string>? Permissions { get; set; }
    public Guid? OrganizationUnitId { get; set; }
    public string? OrganizationUnitName { get; set; }
    public Guid? CompanyId { get; set; }
    public string? JobTitle { get; set; }
    public int? Type { get; set; }
    public string? Status { get; set; }
}