using TD.KCN.WebApi.Application.House.Motels;

namespace TD.KCN.WebApi.Host.Controllers.House;

public class MotelsController : VersionedApiController
{
    [HttpPost("search")]
    [AllowAnonymous]
    [OpenApiOperation("Danh sách địa bàn.", "")]
    public Task<PaginationResponse<MotelDto>> SearchAsync(SearchMotelsRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpGet("{id:guid}")]
    [AllowAnonymous]
    [OpenApiOperation("Chi tiết địa bàn.", "")]
    public Task<Result<MotelDto>> GetAsync(Guid id)
    {
        return Mediator.Send(new GetMotelRequest(id));
    }

    [HttpPost]
    [OpenApiOperation("Tạo mới địa bàn.", "")]
    public Task<Result<Guid>> CreateAsync(CreateMotelRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpPut("{id:guid}")]
    [OpenApiOperation("Cập nhật địa bàn.", "")]
    public async Task<ActionResult<Guid>> UpdateAsync(UpdateMotelRequest request, Guid id)
    {
        return id != request.Id
            ? BadRequest()
            : Ok(await Mediator.Send(request));
    }

    [HttpDelete("{id:guid}")]
    [OpenApiOperation("Xóa địa bàn.", "")]
    public Task<Result<Guid>> DeleteAsync(Guid id)
    {
        return Mediator.Send(new DeleteMotelRequest(id));
    }

}