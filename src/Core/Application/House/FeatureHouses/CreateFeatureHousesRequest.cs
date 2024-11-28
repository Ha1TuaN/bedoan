using TD.KCN.WebApi.Domain.House;

namespace TD.KCN.WebApi.Application.House.FeatureHousess;

public class CreateFeatureHousesRequest : IRequest<Result<Guid>>
{
    public string Name { get; set; } = default!;
    public Guid MotelId { get; set; }
}

public class CreateFeatureHousesRequestValidator : CustomValidator<CreateFeatureHousesRequest>
{
    public CreateFeatureHousesRequestValidator(IReadRepository<FeatureHouse> repository, IStringLocalizer<CreateFeatureHousesRequestValidator> localizer)
    {

    }

}

public class CreateFeatureHousesRequestHandler : IRequestHandler<CreateFeatureHousesRequest, Result<Guid>>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<FeatureHouse> _repository;
    private readonly IStringLocalizer<CreateFeatureHousesRequestHandler> _localizer;

    public CreateFeatureHousesRequestHandler(IRepositoryWithEvents<FeatureHouse> repository, IStringLocalizer<CreateFeatureHousesRequestHandler> localizer) => (_repository, _localizer) = (repository, localizer);

    public async Task<Result<Guid>> Handle(CreateFeatureHousesRequest request, CancellationToken cancellationToken)
    {
        var featureHouses = new FeatureHouse(request.Name, request.MotelId);
        await _repository.AddAsync(featureHouses, cancellationToken);

        return Result<Guid>.Success(featureHouses.Id);
    }
}