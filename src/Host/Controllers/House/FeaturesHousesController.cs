using TD.KCN.WebApi.Application.House.FeatureHouses;
using TD.KCN.WebApi.Application.House.FeatureHousess;

namespace TD.KCN.WebApi.Host.Controllers.House;

public class FeatureHousesController : VersionedApiController
{
    [HttpPost("search")]
    [AllowAnonymous]
    [OpenApiOperation("Danh sách địa bàn.", "")]
    public Task<PaginationResponse<FeatureHouseDto>> SearchAsync(SearchFeatureHousesRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpGet("{id:guid}")]
    [AllowAnonymous]
    [OpenApiOperation("Chi tiết địa bàn.", "")]
    public Task<Result<FeatureHouseDto>> GetAsync(Guid id)
    {
        return Mediator.Send(new GetFeatureHouseRequest(id));
    }

    [HttpPost]
    [MustHavePermission(TDAction.Manage, TDResource.FeatureHouses)]
    [OpenApiOperation("Tạo mới địa bàn.", "")]
    public Task<Result<Guid>> CreateAsync(CreateFeatureHousesRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpPut("{id:guid}")]
    [MustHavePermission(TDAction.Manage, TDResource.FeatureHouses)]
    [OpenApiOperation("Cập nhật địa bàn.", "")]
    public async Task<ActionResult<Guid>> UpdateAsync(UpdateFeatureHouseRequest request, Guid id)
    {
        return id != request.Id
            ? BadRequest()
            : Ok(await Mediator.Send(request));
    }

    [HttpDelete("{id:guid}")]
    [MustHavePermission(TDAction.Manage, TDResource.FeatureHouses)]
    [OpenApiOperation("Xóa địa bàn.", "")]
    public Task<Result<Guid>> DeleteAsync(Guid id)
    {
        return Mediator.Send(new DeleteFeatureHouseRequest(id));
    }

}