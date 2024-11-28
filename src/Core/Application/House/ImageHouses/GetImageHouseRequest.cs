namespace TD.KCN.WebApi.Application.House.ImageHouses;

public class GetImageHouseRequest : IRequest<Result<ImageHouseDto>>
{
    public Guid Id { get; set; }

    public GetImageHouseRequest(Guid id) => Id = id;
}

public class ImageHouseByIdSpec : Specification<ImageHouse, ImageHouseDto>, ISingleResultSpecification<ImageHouse>
{
    public ImageHouseByIdSpec(Guid id) =>
        Query.Where(p => p.Id == id);
}

public class GetImageHouseRequestHandler : IRequestHandler<GetImageHouseRequest, Result<ImageHouseDto>>
{
    private readonly IRepository<ImageHouse> _repository;
    private readonly IStringLocalizer<GetImageHouseRequestHandler> _localizer;

    public GetImageHouseRequestHandler(IRepository<ImageHouse> repository, IStringLocalizer<GetImageHouseRequestHandler> localizer) => (_repository, _localizer) = (repository, localizer);

    public async Task<Result<ImageHouseDto>> Handle(GetImageHouseRequest request, CancellationToken cancellationToken)
    {
        var item = await _repository.FirstOrDefaultAsync(
            (ISpecification<ImageHouse, ImageHouseDto>)new ImageHouseByIdSpec(request.Id), cancellationToken)
        ?? throw new NotFoundException(string.Format(_localizer["ImageHouse.notfound"], request.Id));
        return Result<ImageHouseDto>.Success(item);

    }
}