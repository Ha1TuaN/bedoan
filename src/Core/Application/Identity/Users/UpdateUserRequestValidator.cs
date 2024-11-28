namespace TD.KCN.WebApi.Application.Identity.Users;

public class UpdateUserRequestValidator : CustomValidator<UpdateUserRequest>
{
    public UpdateUserRequestValidator(IUserService userService, IStringLocalizer<UpdateUserRequestValidator> T)
    {
        RuleFor(p => p.Id)
            .NotEmpty();

        RuleFor(p => p.FullName)
            .NotEmpty()
            .MaximumLength(150);

        RuleFor(u => u.PhoneNumber).Cascade(CascadeMode.Stop)
           .MustAsync(async (user, phone, _) => !await userService.ExistsWithPhoneNumberAsync(phone!, user.Id))
               .WithMessage((_, phone) => string.Format(T["Phone number {0} is already registered."], phone))
               .Unless(u => string.IsNullOrWhiteSpace(u.PhoneNumber));

        RuleFor(u => u.Email).Cascade(CascadeMode.Stop)
        .MustAsync(async (user, phone, _) => !await userService.ExistsWithEmailAsync(phone!, user.Id))
        .WithMessage((_, phone) => string.Format(T["Email {0} is already registered."], phone))
        .Unless(u => string.IsNullOrWhiteSpace(u.Email));
    }
}