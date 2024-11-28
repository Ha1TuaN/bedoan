namespace TD.KCN.WebApi.Application.Identity.Users;
public class UpdateUserRolesRequest
{
    public string UserName { get; set; } = default!;
    public string RoleId { get; set; } = default!;
}

public class UpdateUserRolesRequestValidator : CustomValidator<UpdateUserRolesRequest>
{
    public UpdateUserRolesRequestValidator()
    {
        RuleFor(r => r.UserName)
            .NotEmpty();

        RuleFor(r => r.RoleId)
            .NotEmpty();

    }
}
