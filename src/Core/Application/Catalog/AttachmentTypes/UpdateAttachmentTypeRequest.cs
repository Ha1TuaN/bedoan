namespace TD.KCN.WebApi.Application.Catalog.AttachmentTypes;

public class UpdateAttachmentTypeRequest : IRequest<Result<Guid>>
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Code { get; set; }
    public string? Description { get; set; }
    public int? SortOrder { get; set; }
    public bool? IsAllowToDownload { get; set; }
    public bool? IsActive { get; set; }
}

public class UpdateAttachmentTypeRequestHandler : IRequestHandler<UpdateAttachmentTypeRequest, Result<Guid>>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<AttachmentType> _repository;
    private readonly IStringLocalizer _t;

    public UpdateAttachmentTypeRequestHandler(IRepositoryWithEvents<AttachmentType> repository, IStringLocalizer<UpdateAttachmentTypeRequestHandler> localizer) =>
        (_repository, _t) = (repository, localizer);

    public async Task<Result<Guid>> Handle(UpdateAttachmentTypeRequest request, CancellationToken cancellationToken)
    {
        var item = await _repository.GetByIdAsync(request.Id, cancellationToken);

        _ = item
        ?? throw new NotFoundException(_t["AttachmentType {0} Not Found.", request.Id]);

        item.Update(
            request.Name,
            request.Code,
            request.Description,
            request.SortOrder,
            request.IsAllowToDownload,
            request.IsActive);

        await _repository.UpdateAsync(item, cancellationToken);

        return Result<Guid>.Success(request.Id);
    }
}