using TD.KCN.WebApi.Domain.House;

namespace TD.KCN.WebApi.Application.House.FeatureHouses;

public class SearchFeatureHousesRequest : PaginationFilter, IRequest<PaginationResponse<FeatureHouseDto>>
{

}

public class FeatureHousesBySearchRequestSpec : EntitiesByPaginationFilterSpec<FeatureHouse, FeatureHouseDto>
{
    public FeatureHousesBySearchRequestSpec(SearchFeatureHousesRequest request)
        : base(request) =>
        Query
            .OrderBy(c => c.Name, !request.HasOrderBy());
}

public class SearchCategoriesRequestHandler : IRequestHandler<SearchFeatureHousesRequest, PaginationResponse<FeatureHouseDto>>
{
    private readonly IReadRepository<FeatureHouse> _repository;

    public SearchCategoriesRequestHandler(IReadRepository<FeatureHouse> repository) => _repository = repository;

    public async Task<PaginationResponse<FeatureHouseDto>> Handle(SearchFeatureHousesRequest request, CancellationToken cancellationToken)
    {
        var spec = new FeatureHousesBySearchRequestSpec(request);

        var list = await _repository.ListAsync(spec, cancellationToken);
        int count = await _repository.CountAsync(spec, cancellationToken);

        return new PaginationResponse<FeatureHouseDto>(list, count, request.PageNumber, request.PageSize);
    }
}