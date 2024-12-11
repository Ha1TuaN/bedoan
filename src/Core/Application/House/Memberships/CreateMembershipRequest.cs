namespace TD.KCN.WebApi.Application.House.Memberships;

public class CreateMembershipRequest : IRequest<Result<Guid>>
{
    public string Name { get; set; } = default!;
    public decimal Price { get; set; }
    public string? MonthlyNewsletter { get; set; }
    public string? Utilities { get; set; }
}

public class CreateMembershipRequestValidator : CustomValidator<CreateMembershipRequest>
{
    public CreateMembershipRequestValidator(IReadRepository<Membership> repository, IStringLocalizer<CreateMembershipRequestValidator> localizer)
    {

    }

}

public class CreateMembershipRequestHandler : IRequestHandler<CreateMembershipRequest, Result<Guid>>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<Membership> _repository;

    public CreateMembershipRequestHandler(IRepositoryWithEvents<Membership> repository) 
    {
        _repository = repository;
    }
 
    public async Task<Result<Guid>> Handle(CreateMembershipRequest request, CancellationToken cancellationToken)
    {
        var membership = new Membership(
           request.Name,
           request.Price,
           request.MonthlyNewsletter,
           request.Utilities);
        await _repository.AddAsync(membership, cancellationToken);

        return Result<Guid>.Success(membership.Id);
    }
}