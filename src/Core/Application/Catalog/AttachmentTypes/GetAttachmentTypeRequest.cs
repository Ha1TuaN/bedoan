namespace TD.KCN.WebApi.Application.Catalog.AttachmentTypes;

public class GetAttachmentTypeRequest : IRequest<Result<AttachmentTypeDto>>
{
    public Guid Id { get; set; }

    public GetAttachmentTypeRequest(Guid id) => Id = id;
}

public class AttachmentTypeByIdSpec : Specification<AttachmentType, AttachmentTypeDto>, ISingleResultSpecification<AttachmentType>
{
    public AttachmentTypeByIdSpec(Guid id) =>
        Query.Where(p => p.Id == id);
}

public class GetAttachmentTypeRequestHandler : IRequestHandler<GetAttachmentTypeRequest, Result<AttachmentTypeDto>>
{
    private readonly IRepository<AttachmentType> _repository;
    private readonly IStringLocalizer _t;

    public GetAttachmentTypeRequestHandler(IRepository<AttachmentType> repository, IStringLocalizer<GetAttachmentTypeRequestHandler> localizer) => (_repository, _t) = (repository, localizer);

    [Obsolete]
    public async Task<Result<AttachmentTypeDto>> Handle(GetAttachmentTypeRequest request, CancellationToken cancellationToken)
    {
        var item = await _repository.GetBySpecAsync(
            (ISpecification<AttachmentType, AttachmentTypeDto>)new AttachmentTypeByIdSpec(request.Id), cancellationToken)
        ?? throw new NotFoundException(_t["AttachmentType {0} Not Found.", request.Id]);
        return Result<AttachmentTypeDto>.Success(item);
    }
}