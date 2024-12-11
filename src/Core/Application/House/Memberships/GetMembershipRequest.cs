using TD.KCN.WebApi.Application.Identity.Users;

namespace TD.KCN.WebApi.Application.House.Memberships;

public class GetMembershipRequest : IRequest<Result<MembershipDto>>
{
    public Guid Id { get; set; }

    public GetMembershipRequest(Guid id) => Id = id;
}

public class MembershipByIdSpec : Specification<Membership, MembershipDto>, ISingleResultSpecification<Membership>
{
    public MembershipByIdSpec(Guid id) =>
        Query.Where(p => p.Id == id);
}

public class GetMembershipRequestHandler : IRequestHandler<GetMembershipRequest, Result<MembershipDto>>
{
    private readonly IRepository<Membership> _repository;

    private readonly IStringLocalizer<GetMembershipRequestHandler> _localizer;

    public GetMembershipRequestHandler(IRepository<Membership> repository, IStringLocalizer<GetMembershipRequestHandler> localizer) => (_repository, _localizer) = (repository, localizer);

    public async Task<Result<MembershipDto>> Handle(GetMembershipRequest request, CancellationToken cancellationToken)
    {
        var item = await _repository.FirstOrDefaultAsync(
            (ISpecification<Membership, MembershipDto>)new MembershipByIdSpec(request.Id), cancellationToken)
        ?? throw new NotFoundException(string.Format(_localizer["Membership.notfound"], request.Id));

        return Result<MembershipDto>.Success(item);

    }
}