using TD.KCN.WebApi.Application.Identity.Users;

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
    public string? Status { get; set; }
    public bool? IsVip { get; set; }
}

public class MotelsBySearchRequestSpec : EntitiesByPaginationFilterSpec<Motel, MotelDto>
{
    public MotelsBySearchRequestSpec(SearchMotelsRequest request)
        : base(request)
    {
        Query.OrderBy(c => c.Address, !request.HasOrderBy())
             .Where(c => c.Status == request.Status, !string.IsNullOrEmpty(request.Status))
             .Where(c => c.ProvinceId == request.ProvinceId, request.ProvinceId.HasValue)
             .Where(c => c.DistrictId == request.DistrictId, request.DistrictId.HasValue)
             .Where(c => c.IsVip == request.IsVip, request.IsVip.HasValue);
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

        if (request.BathroomCount != null && request.BathroomCount.Count == 2)
        {
            decimal minBathroomCount = request.BathroomCount[0];
            decimal maxBathroomCOunt = request.BathroomCount[1];
            Query.Where(c => c.BathroomCount >= minBathroomCount && c.BathroomCount <= maxBathroomCOunt);
        }

        if (request.BedroomCount != null && request.BedroomCount.Count == 2)
        {
            decimal minBedroomCount = request.BedroomCount[0];
            decimal maxBedroomCOunt = request.BedroomCount[1];
            Query.Where(c => c.BedroomCount >= minBedroomCount && c.BedroomCount <= maxBedroomCOunt);
        }
    }

}

public class SearchMotelRequestHandler : IRequestHandler<SearchMotelsRequest, PaginationResponse<MotelDto>>
{
    private readonly IReadRepository<Motel> _repository;
    private readonly IUserService _userService;
    public SearchMotelRequestHandler(IReadRepository<Motel> repository, IUserService userService)
    {
        _repository = repository;
        _userService = userService;
    }

    public async Task<PaginationResponse<MotelDto>> Handle(SearchMotelsRequest request, CancellationToken cancellationToken)
    {
        var spec = new MotelsBySearchRequestSpec(request);

        var list = await _repository.ListAsync(spec, cancellationToken);

        foreach (var item in list)
        {
            var user = await _userService.GetAsync(item.UserId, cancellationToken);
            item.UserAvatar = user.ImageUrl;
            item.UserPhone = user.PhoneNumber;
            item.UserFullName = user.FullName;
        }

        int count = await _repository.CountAsync(spec, cancellationToken);

        return new PaginationResponse<MotelDto>(list, count, request.PageNumber, request.PageSize);
    }
}