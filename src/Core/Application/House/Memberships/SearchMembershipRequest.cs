using TD.KCN.WebApi.Application.Identity.Users;

namespace TD.KCN.WebApi.Application.House.Memberships;

public class SearchMembershipsRequest : PaginationFilter, IRequest<PaginationResponse<MembershipDto>>
{

}

public class MembershipsBySearchRequestSpec : EntitiesByPaginationFilterSpec<Membership, MembershipDto>
{
    public MembershipsBySearchRequestSpec(SearchMembershipsRequest request)
        : base(request)
    {
        Query.OrderBy(c => c.Name, !request.HasOrderBy());
    }

}

public class SearchMembershipRequestHandler : IRequestHandler<SearchMembershipsRequest, PaginationResponse<MembershipDto>>
{
    private readonly IReadRepository<Membership> _repository;
    private readonly IUserService _userService;
    public SearchMembershipRequestHandler(IReadRepository<Membership> repository, IUserService userService)
    {
        _repository = repository;
        _userService = userService;
    }

    public async Task<PaginationResponse<MembershipDto>> Handle(SearchMembershipsRequest request, CancellationToken cancellationToken)
    {
        var spec = new MembershipsBySearchRequestSpec(request);

        var list = await _repository.ListAsync(spec, cancellationToken);

        int count = await _repository.CountAsync(spec, cancellationToken);

        return new PaginationResponse<MembershipDto>(list, count, request.PageNumber, request.PageSize);
    }
}