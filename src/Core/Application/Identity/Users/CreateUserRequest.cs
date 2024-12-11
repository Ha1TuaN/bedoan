namespace TD.KCN.WebApi.Application.Identity.Users;

public class CreateUserRequest
{
    public string? FullName { get; set; }
    public string UserName { get; set; } = default!;
    public string? Address { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string Password { get; set; } = default!;
    public string ConfirmPassword { get; set; } = default!;
    public DateTime? CreatedOn { get; set; } = DateTime.Now;

}