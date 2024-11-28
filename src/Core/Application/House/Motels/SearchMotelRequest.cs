namespace TD.KCN.WebApi.Application.House.Motels;

public class SearchMotelsRequest : PaginationFilter, IRequest<PaginationResponse<MotelDto>>
{
    public Guid? DistrictId { get; set; }
    public Guid? ProvinceId { get; set; }
    public List<string>? Type { get; set; }
    public List<decimal>? Price { get; set; }
    public List<decimal>? Area { get; set; }
    public List<int>? BedroomCount { get; set; }
    public List<int>? BathroomCount { get; set; }
}

public class MotelsBySearchRequestSpec : EntitiesByPaginationFilterSpec<Motel, MotelDto>
{
    public MotelsBySearchRequestSpec(SearchMotelsRequest request)
        : base(request)
    {
        Query.OrderBy(c => c.Title, !request.HasOrderBy())
             .Where(c => c.ProvinceId == request.ProvinceId, request.ProvinceId.HasValue)
             .Where(c => c.DistrictId == request.DistrictId, request.DistrictId.HasValue);
        if (request.Type != null && request.Type.Count > 0)
        {
            Query.Where(c => request.Type.Contains(c.Type));
        }

        if (request.Price != null && request.Price.Count == 2)
        {
            decimal minPrice = request.Price[0];
            decimal maxPrice = request.Price[1];
            Query.Where(c => c.Price >= minPrice && c.Price <= maxPrice);
        }

        if (request.Area != null && request.Area.Count == 2)
        {
            decimal minArea = request.Area[0];
            decimal maxArea = request.Area[1];
            Query.Where(c => c.Area >= minArea && c.Area <= maxArea);
        }

        if (request.BathroomCount != null)
        {
            Query.Where(c => request.BathroomCount.Contains(c.BathroomCount));
        }

        if (request.BedroomCount != null)
        {
            Query.Where(c => request.BedroomCount.Contains(c.BedroomCount));
        }
    }

}

public class SearchMotelRequestHandler : IRequestHandler<SearchMotelsRequest, PaginationResponse<MotelDto>>
{
    private readonly IReadRepository<Motel> _repository;

    public SearchMotelRequestHandler(IReadRepository<Motel> repository) => _repository = repository;

    public async Task<PaginationResponse<MotelDto>> Handle(SearchMotelsRequest request, CancellationToken cancellationToken)
    {
        var spec = new MotelsBySearchRequestSpec(request);

        var list = await _repository.ListAsync(spec, cancellationToken);
        int count = await _repository.CountAsync(spec, cancellationToken);

        return new PaginationResponse<MotelDto>(list, count, request.PageNumber, request.PageSize);
    }
}