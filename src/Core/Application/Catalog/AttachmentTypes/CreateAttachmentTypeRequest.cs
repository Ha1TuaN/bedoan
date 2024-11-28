namespace TD.KCN.WebApi.Application.Catalog.AttachmentTypes;

public class CreateAttachmentTypeRequest : IRequest<Result<Guid>>
{
    public string Name { get; set; } = default!;
    public string? Code { get; set; }
    public string? Description { get; set; }
    public int? SortOrder { get; set; }
    public bool? IsAllowToDownload { get; set; } = false;
    public bool? IsActive { get; set; } = false;
}

public class CreateAttachmentTypeRequestHandler : IRequestHandler<CreateAttachmentTypeRequest, Result<Guid>>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<AttachmentType> _repository;

    public CreateAttachmentTypeRequestHandler(IRepositoryWithEvents<AttachmentType> repository) => _repository = repository;

    public async Task<Result<Guid>> Handle(CreateAttachmentTypeRequest request, CancellationToken cancellationToken)
    {
        var item = new AttachmentType(
            request.Name,
            request.Code,
            request.Description,
            request.SortOrder,
            request.IsAllowToDownload,
            request.IsActive);

        await _repository.AddAsync(item, cancellationToken);

        return Result<Guid>.Success(item.Id);
    }
}