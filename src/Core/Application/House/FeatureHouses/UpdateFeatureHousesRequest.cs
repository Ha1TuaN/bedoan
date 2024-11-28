namespace TD.KCN.WebApi.Application.House.FeatureHouses;

public class UpdateFeatureHouseRequest : IRequest<Result<Guid>>
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
}

public class UpdateFeatureHouseRequestValidator : CustomValidator<UpdateFeatureHouseRequest>
{
    public UpdateFeatureHouseRequestValidator(IRepository<FeatureHouse> repository, IStringLocalizer<UpdateFeatureHouseRequestValidator> localizer)
    {

    }

}

public class UpdateFeatureHouseRequestHandler : IRequestHandler<UpdateFeatureHouseRequest, Result<Guid>>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<FeatureHouse> _repository;
    private readonly IStringLocalizer<UpdateFeatureHouseRequestHandler> _localizer;

    public UpdateFeatureHouseRequestHandler(IRepositoryWithEvents<FeatureHouse> repository, IStringLocalizer<UpdateFeatureHouseRequestHandler> localizer) =>
        (_repository, _localizer) = (repository, localizer);

    public async Task<Result<Guid>> Handle(UpdateFeatureHouseRequest request, CancellationToken cancellationToken)
    {
        var item = await _repository.GetByIdAsync(request.Id, cancellationToken);

        _ = item ?? throw new NotFoundException(string.Format(_localizer["FeatureHouse.notfound"], request.Id));

        item.Update(request.Name);

        await _repository.UpdateAsync(item, cancellationToken);

        return Result<Guid>.Success(request.Id);
    }

}