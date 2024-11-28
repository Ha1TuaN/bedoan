using TD.KCN.WebApi.Application.Catalog.AttachmentTypes;

namespace TD.WebApi.Host.Controllers.Catalog;

public class AttachmentTypesController : VersionedApiController
{
    [HttpPost("search")]
    [AllowAnonymous]
    [OpenApiOperation("Danh sách loại đính kèm.", "")]
    public Task<PaginationResponse<AttachmentTypeDto>> SearchAsync(SearchAttachmentTypesRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpGet("{id:guid}")]
    [OpenApiOperation("Chi tiết loại đính kèm.", "")]
    public Task<Result<AttachmentTypeDto>> GetAsync(Guid id)
    {
        return Mediator.Send(new GetAttachmentTypeRequest(id));
    }

    [HttpPost]
    [OpenApiOperation("Tạo mới loại đính kèm.", "")]
    public Task<Result<Guid>> CreateAsync(CreateAttachmentTypeRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpPut("{id:guid}")]
    [OpenApiOperation("Cập nhật loại đính kèm.", "")]
    public async Task<ActionResult<Guid>> UpdateAsync(UpdateAttachmentTypeRequest request, Guid id)
    {
        return id != request.Id
            ? BadRequest()
            : Ok(await Mediator.Send(request));
    }

    [HttpDelete("{id:guid}")]
    [OpenApiOperation("Xóa loại đính kèm.", "")]
    public Task<Result<Guid>> DeleteAsync(Guid id)
    {
        return Mediator.Send(new DeleteAttachmentTypeRequest(id));
    }

}