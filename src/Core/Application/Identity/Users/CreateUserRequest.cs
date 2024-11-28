namespace TD.KCN.WebApi.Application.Identity.Users;

public class CreateUserRequest
{
    public string? FullName { get; set; }
    public string UserName { get; set; } = default!;
    public string? Gender { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Address { get; set; }
    public string Email { get; set; } = default!;
    public string? PhoneNumber { get; set; }
    public string? ImageUrl { get; set; }
    public string Password { get; set; } = default!;
    public string ConfirmPassword { get; set; } = default!;

    /// <summary>
    /// Loại người dùng
    /// 0: Quản trị viên
    /// 1: Doanh nghiệp
    /// 2: Nhân viên.
    /// </summary>
    public int? Type { get; set; } = 1;
    public string? Status { get; set; }
    public DateTime? CreatedOn { get; set; } = DateTime.Now;

}