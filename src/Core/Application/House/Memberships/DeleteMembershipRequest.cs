namespace TD.KCN.WebApi.Application.House.Memberships;

public class DeleteMembershipRequest : IRequest<Result<Guid>>
{
    public Guid Id { get; set; }

    public DeleteMembershipRequest(Guid id) => Id = id;
}

public class DeleteMembershipRequestHandler : IRequestHandler<DeleteMembershipRequest, Result<Guid>>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<Membership> _membershipRepo;
    private readonly IStringLocalizer _t;

    public DeleteMembershipRequestHandler(IRepositoryWithEvents<Membership> MembershipRepo, IStringLocalizer<DeleteMembershipRequestHandler> t)
    {
        _membershipRepo = MembershipRepo;
        _t = t;
    }

    public async Task<Result<Guid>> Handle(DeleteMembershipRequest request, CancellationToken cancellationToken)
    {
        var membership = await _membershipRepo.GetByIdAsync(request.Id, cancellationToken);

        _ = membership ?? throw new NotFoundException(_t["Membership.notfound"]);

        await _membershipRepo.DeleteAsync(membership, cancellationToken);

        return Result<Guid>.Success(request.Id);
    }
}