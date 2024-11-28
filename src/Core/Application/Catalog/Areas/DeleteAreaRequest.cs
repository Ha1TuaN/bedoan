namespace TD.KCN.WebApi.Application.Catalog.Areas;

public class DeleteAreaRequest : IRequest<Result<Guid>>
{
    public Guid Id { get; set; }

    public DeleteAreaRequest(Guid id) => Id = id;
}

public class DeleteAreaRequestHandler : IRequestHandler<DeleteAreaRequest, Result<Guid>>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<Area> _areaRepo;
    private readonly IStringLocalizer<DeleteAreaRequestHandler> _localizer;

    public DeleteAreaRequestHandler(IRepositoryWithEvents<Area> areaRepo, IStringLocalizer<DeleteAreaRequestHandler> localizer) =>
        (_areaRepo, _localizer) = (areaRepo, localizer);

    public async Task<Result<Guid>> Handle(DeleteAreaRequest request, CancellationToken cancellationToken)
    {
        var area = await _areaRepo.GetByIdAsync(request.Id, cancellationToken);

        _ = area ?? throw new NotFoundException(_localizer["area.notfound"]);

        if (await _areaRepo.AnyAsync(new AreasByParentCodeSpec(area.Code), cancellationToken))
        {
            throw new ConflictException(_localizer["area.cannotbedeleted"]);
        }

        await _areaRepo.DeleteAsync(area, cancellationToken);

        return Result<Guid>.Success(request.Id);
    }
}