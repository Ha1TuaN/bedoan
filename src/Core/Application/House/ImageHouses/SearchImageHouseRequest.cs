using TD.KCN.WebApi.Domain.House;

namespace TD.KCN.WebApi.Application.House.ImageHouses;

public class SearchImageHousesRequest : PaginationFilter, IRequest<PaginationResponse<ImageHouseDto>>
{

}

public class ImageHousesBySearchRequestSpec : EntitiesByPaginationFilterSpec<ImageHouse, ImageHouseDto>
{
    public ImageHousesBySearchRequestSpec(SearchImageHousesRequest request)
        : base(request) =>
        Query
            .OrderBy(c => c.Image, !request.HasOrderBy());
}

public class SearchCategoriesRequestHandler : IRequestHandler<SearchImageHousesRequest, PaginationResponse<ImageHouseDto>>
{
    private readonly IReadRepository<ImageHouse> _repository;

    public SearchCategoriesRequestHandler(IReadRepository<ImageHouse> repository) => _repository = repository;

    public async Task<PaginationResponse<ImageHouseDto>> Handle(SearchImageHousesRequest request, CancellationToken cancellationToken)
    {
        var spec = new ImageHousesBySearchRequestSpec(request);

        var list = await _repository.ListAsync(spec, cancellationToken);
        int count = await _repository.CountAsync(spec, cancellationToken);

        return new PaginationResponse<ImageHouseDto>(list, count, request.PageNumber, request.PageSize);
    }
}