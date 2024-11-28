using TD.KCN.WebApi.Domain.House;

namespace TD.KCN.WebApi.Application.House.ImageHouses;

public class CreateImageHouseRequest : IRequest<Result<Guid>>
{
    public string Image { get; set; } = default!;
    public Guid? MotelId { get; set; }
}

public class CreateImageHouseRequestValidator : CustomValidator<CreateImageHouseRequest>
{
    public CreateImageHouseRequestValidator(IReadRepository<FeatureHouse> repository, IStringLocalizer<CreateImageHouseRequestValidator> localizer)
    {

    }

}

public class CreateImageHouseRequestHandler : IRequestHandler<CreateImageHouseRequest, Result<Guid>>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<ImageHouse> _repository;
    private readonly IStringLocalizer<CreateImageHouseRequestHandler> _localizer;

    public CreateImageHouseRequestHandler(IRepositoryWithEvents<ImageHouse> repository, IStringLocalizer<CreateImageHouseRequestHandler> localizer) => (_repository, _localizer) = (repository, localizer);

    public async Task<Result<Guid>> Handle(CreateImageHouseRequest request, CancellationToken cancellationToken)
    {
        var imageHouse = new ImageHouse(request.Image, request.MotelId);
        await _repository.AddAsync(imageHouse, cancellationToken);

        return Result<Guid>.Success(imageHouse.Id);
    }
}