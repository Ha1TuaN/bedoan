namespace TD.KCN.WebApi.Application.House.ImageHouses;

public class UpdateImageHouseRequest : IRequest<Result<Guid>>
{
    public Guid Id { get; set; }
    public string? Image { get; set; }
    public Guid? MotelId { get; set; }

}

public class UpdateImageHouseRequestValidator : CustomValidator<UpdateImageHouseRequest>
{
    public UpdateImageHouseRequestValidator(IRepository<ImageHouse> repository, IStringLocalizer<UpdateImageHouseRequestValidator> localizer)
    {

    }

}

public class UpdateImageHouseRequestHandler : IRequestHandler<UpdateImageHouseRequest, Result<Guid>>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<ImageHouse> _repository;
    private readonly IStringLocalizer<UpdateImageHouseRequestHandler> _localizer;

    public UpdateImageHouseRequestHandler(IRepositoryWithEvents<ImageHouse> repository, IStringLocalizer<UpdateImageHouseRequestHandler> localizer) =>
        (_repository, _localizer) = (repository, localizer);

    public async Task<Result<Guid>> Handle(UpdateImageHouseRequest request, CancellationToken cancellationToken)
    {
        var item = await _repository.GetByIdAsync(request.Id, cancellationToken);

        _ = item ?? throw new NotFoundException(string.Format(_localizer["ImageHouse.notfound"], request.Id));

        item.Update(request.Image, request.MotelId);

        await _repository.UpdateAsync(item, cancellationToken);

        return Result<Guid>.Success(request.Id);
    }

}