namespace TD.KCN.WebApi.Application.Catalog.AttachmentTypes;

public class SearchAttachmentTypesRequest : PaginationFilter, IRequest<PaginationResponse<AttachmentTypeDto>>
{
    public bool? IsActive { get; set; }
}

public class AttachmentTypesBySearchRequestSpec : EntitiesByPaginationFilterSpec<AttachmentType, AttachmentTypeDto>
{
    public AttachmentTypesBySearchRequestSpec(SearchAttachmentTypesRequest request)
        : base(request) =>
        Query.OrderBy(c => c.Name, !request.HasOrderBy())
        .Where(p => p.IsActive == request.IsActive, request.IsActive.HasValue);
}

public class SearchAttachmentTypesRequestHandler : IRequestHandler<SearchAttachmentTypesRequest, PaginationResponse<AttachmentTypeDto>>
{
    private readonly IReadRepository<AttachmentType> _repository;

    public SearchAttachmentTypesRequestHandler(IReadRepository<AttachmentType> repository) => _repository = repository;

    public async Task<PaginationResponse<AttachmentTypeDto>> Handle(SearchAttachmentTypesRequest request, CancellationToken cancellationToken)
    {
        var spec = new AttachmentTypesBySearchRequestSpec(request);
        return await _repository.PaginatedListAsync(spec, request.PageNumber, request.PageSize, cancellationToken);
    }
}