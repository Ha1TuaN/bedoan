using TD.KCN.WebApi.Application.Catalog.Areas;

namespace TD.KCN.WebApi.Host.Controllers.Catalog;

public class AreasController : VersionedApiController
{
    [HttpPost("search")]
    [AllowAnonymous]
    [OpenApiOperation("Danh sách địa bàn.", "")]
    public Task<PaginationResponse<AreaDto>> SearchAsync(SearchAreasRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpGet("{id:guid}")]
    [AllowAnonymous]
    [OpenApiOperation("Chi tiết địa bàn.", "")]
    public Task<Result<AreaDetailsDto>> GetAsync(Guid id)
    {
        return Mediator.Send(new GetAreaRequest(id));
    }

    [HttpPost]
    [MustHavePermission(TDAction.Manage, TDResource.Areas)]
    [OpenApiOperation("Tạo mới địa bàn.", "")]
    public Task<Result<Guid>> CreateAsync(CreateAreaRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpPut("{id:guid}")]
    [MustHavePermission(TDAction.Manage, TDResource.Areas)]
    [OpenApiOperation("Cập nhật địa bàn.", "")]
    public async Task<ActionResult<Guid>> UpdateAsync(UpdateAreaRequest request, Guid id)
    {
        return id != request.Id
            ? BadRequest()
            : Ok(await Mediator.Send(request));
    }

    [HttpDelete("{id:guid}")]
    [MustHavePermission(TDAction.Manage, TDResource.Areas)]
    [OpenApiOperation("Xóa địa bàn.", "")]
    public Task<Result<Guid>> DeleteAsync(Guid id)
    {
        return Mediator.Send(new DeleteAreaRequest(id));
    }

}