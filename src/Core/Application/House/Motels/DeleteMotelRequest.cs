namespace TD.KCN.WebApi.Application.House.Motels;

public class DeleteMotelRequest : IRequest<Result<Guid>>
{
    public Guid Id { get; set; }

    public DeleteMotelRequest(Guid id) => Id = id;
}

public class DeleteMotelRequestHandler : IRequestHandler<DeleteMotelRequest, Result<Guid>>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<Motel> _motelRepo;
    private readonly IStringLocalizer _t;

    public DeleteMotelRequestHandler(IRepositoryWithEvents<Motel> motelRepo, IStringLocalizer<DeleteMotelRequestHandler> t)
    {
        _motelRepo = motelRepo;
        _t = t;
    }

    public async Task<Result<Guid>> Handle(DeleteMotelRequest request, CancellationToken cancellationToken)
    {
        var motel = await _motelRepo.GetByIdAsync(request.Id, cancellationToken);

        _ = motel ?? throw new NotFoundException(_t["Motel.notfound"]);

        await _motelRepo.DeleteAsync(motel, cancellationToken);

        return Result<Guid>.Success(request.Id);
    }
}