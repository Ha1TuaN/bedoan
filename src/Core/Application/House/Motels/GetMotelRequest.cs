namespace TD.KCN.WebApi.Application.House.Motels;

public class GetMotelRequest : IRequest<Result<MotelDto>>
{
    public Guid Id { get; set; }

    public GetMotelRequest(Guid id) => Id = id;
}

public class MotelByIdSpec : Specification<Motel, MotelDto>, ISingleResultSpecification<Motel>
{
    public MotelByIdSpec(Guid id) =>
        Query.Where(p => p.Id == id);
}

public class GetMotelRequestHandler : IRequestHandler<GetMotelRequest, Result<MotelDto>>
{
    private readonly IRepository<Motel> _repository;
    private readonly IStringLocalizer<GetMotelRequestHandler> _localizer;

    public GetMotelRequestHandler(IRepository<Motel> repository, IStringLocalizer<GetMotelRequestHandler> localizer) => (_repository, _localizer) = (repository, localizer);

    public async Task<Result<MotelDto>> Handle(GetMotelRequest request, CancellationToken cancellationToken)
    {
        var item = await _repository.FirstOrDefaultAsync(
            (ISpecification<Motel, MotelDto>)new MotelByIdSpec(request.Id), cancellationToken)
        ?? throw new NotFoundException(string.Format(_localizer["Motel.notfound"], request.Id));
        return Result<MotelDto>.Success(item);

    }
}