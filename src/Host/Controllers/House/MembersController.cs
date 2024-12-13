using TD.KCN.WebApi.Application.House.Memberships;

namespace TD.KCN.WebApi.Host.Controllers.House;

public class MemberhipsController : VersionedApiController
{
    [HttpPost("search")]
    [AllowAnonymous]
    [OpenApiOperation("Danh sách địa bàn.", "")]
    public Task<PaginationResponse<MembershipDto>> SearchAsync(SearchMembershipsRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpGet("{id:guid}")]
    [AllowAnonymous]
    [OpenApiOperation("Chi tiết địa bàn.", "")]
    public Task<Result<MembershipDto>> GetAsync(Guid id)
    {
        return Mediator.Send(new GetMembershipRequest(id));
    }

    [HttpPost]
    [AllowAnonymous]
    [OpenApiOperation("Tạo mới địa bàn.", "")]
    public Task<Result<Guid>> CreateAsync(CreateMembershipRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpPut("{id:guid}")]
    [AllowAnonymous]
    [OpenApiOperation("Cập nhật địa bàn.", "")]
    public async Task<ActionResult<Guid>> UpdateAsync(UpdateMembershipRequest request, Guid id)
    {
        return id != request.Id
            ? BadRequest()
            : Ok(await Mediator.Send(request));
    }

    [HttpDelete("{id:guid}")]
    [AllowAnonymous]
    [OpenApiOperation("Xóa địa bàn.", "")]
    public Task<Result<Guid>> DeleteAsync(Guid id)
    {
        return Mediator.Send(new DeleteMembershipRequest(id));
    }

}