namespace TD.KCN.WebApi.Application.House.FeatureHouses;

public class DeleteFeatureHouseRequest : IRequest<Result<Guid>>
{
    public Guid Id { get; set; }

    public DeleteFeatureHouseRequest(Guid id) => Id = id;
}

public class DeleteFeatureHouseRequestHandler : IRequestHandler<DeleteFeatureHouseRequest, Result<Guid>>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<FeatureHouse> _featureHouseRepo;
    private readonly IStringLocalizer<DeleteFeatureHouseRequestHandler> _localizer;

    public DeleteFeatureHouseRequestHandler(IRepositoryWithEvents<FeatureHouse> featureHouseRepo, IStringLocalizer<DeleteFeatureHouseRequestHandler> localizer) =>
        (_featureHouseRepo, _localizer) = (featureHouseRepo, localizer);

    public async Task<Result<Guid>> Handle(DeleteFeatureHouseRequest request, CancellationToken cancellationToken)
    {
        var featureHouse = await _featureHouseRepo.GetByIdAsync(request.Id, cancellationToken);

        _ = featureHouse ?? throw new NotFoundException(_localizer["FeatureHouse.notfound"]);

        await _featureHouseRepo.DeleteAsync(featureHouse, cancellationToken);

        return Result<Guid>.Success(request.Id);
    }
}