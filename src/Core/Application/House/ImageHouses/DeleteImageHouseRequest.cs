namespace TD.KCN.WebApi.Application.House.ImageHouses;

public class DeleteImageHouseRequest : IRequest<Result<Guid>>
{
    public Guid Id { get; set; }

    public DeleteImageHouseRequest(Guid id) => Id = id;
}

public class DeleteImageHouseRequestHandler : IRequestHandler<DeleteImageHouseRequest, Result<Guid>>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<ImageHouse> _repo;
    private readonly IStringLocalizer<DeleteImageHouseRequestHandler> _localizer;

    public DeleteImageHouseRequestHandler(IRepositoryWithEvents<ImageHouse> repo, IStringLocalizer<DeleteImageHouseRequestHandler> localizer) =>
        (_repo, _localizer) = (repo, localizer);

    public async Task<Result<Guid>> Handle(DeleteImageHouseRequest request, CancellationToken cancellationToken)
    {
        var imageHouse = await _repo.GetByIdAsync(request.Id, cancellationToken);

        _ = imageHouse ?? throw new NotFoundException(_localizer["ImageHouse.notfound"]);

        await _repo.DeleteAsync(imageHouse, cancellationToken);

        return Result<Guid>.Success(request.Id);
    }
}