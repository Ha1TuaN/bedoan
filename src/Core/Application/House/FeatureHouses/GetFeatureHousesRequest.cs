namespace TD.KCN.WebApi.Application.House.FeatureHouses;

public class GetFeatureHouseRequest : IRequest<Result<FeatureHouseDto>>
{
    public Guid Id { get; set; }

    public GetFeatureHouseRequest(Guid id) => Id = id;
}

public class FeatureHouseByIdSpec : Specification<FeatureHouse, FeatureHouseDto>, ISingleResultSpecification<FeatureHouse>
{
    public FeatureHouseByIdSpec(Guid id) =>
        Query.Where(p => p.Id == id);
}

public class GetFeatureHouseRequestHandler : IRequestHandler<GetFeatureHouseRequest, Result<FeatureHouseDto>>
{
    private readonly IRepository<FeatureHouse> _repository;
    private readonly IStringLocalizer<GetFeatureHouseRequestHandler> _localizer;

    public GetFeatureHouseRequestHandler(IRepository<FeatureHouse> repository, IStringLocalizer<GetFeatureHouseRequestHandler> localizer) => (_repository, _localizer) = (repository, localizer);

    public async Task<Result<FeatureHouseDto>> Handle(GetFeatureHouseRequest request, CancellationToken cancellationToken)
    {
        var item = await _repository.FirstOrDefaultAsync(
            (ISpecification<FeatureHouse, FeatureHouseDto>)new FeatureHouseByIdSpec(request.Id), cancellationToken)
        ?? throw new NotFoundException(string.Format(_localizer["FeatureHouse.notfound"], request.Id));
        return Result<FeatureHouseDto>.Success(item);

    }
}