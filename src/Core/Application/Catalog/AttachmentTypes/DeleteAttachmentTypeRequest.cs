namespace TD.KCN.WebApi.Application.Catalog.AttachmentTypes;

public class DeleteAttachmentTypeRequest : IRequest<Result<Guid>>
{
    public Guid Id { get; set; }

    public DeleteAttachmentTypeRequest(Guid id) => Id = id;
}

public class DeleteAttachmentTypeRequestHandler : IRequestHandler<DeleteAttachmentTypeRequest, Result<Guid>>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<AttachmentType> _repository;
    private readonly IStringLocalizer _t;

    public DeleteAttachmentTypeRequestHandler(IRepositoryWithEvents<AttachmentType> repository, IStringLocalizer<DeleteAttachmentTypeRequestHandler> localizer) =>
        (_repository, _t) = (repository, localizer);

    public async Task<Result<Guid>> Handle(DeleteAttachmentTypeRequest request, CancellationToken cancellationToken)
    {
        var item = await _repository.GetByIdAsync(request.Id, cancellationToken);

        _ = item ?? throw new NotFoundException(_t["AttachmentType {0} Not Found."]);

        await _repository.DeleteAsync(item, cancellationToken);

        return Result<Guid>.Success(request.Id);
    }
}