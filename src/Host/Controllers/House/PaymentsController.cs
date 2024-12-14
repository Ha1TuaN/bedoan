using TD.KCN.WebApi.Application.House.Motels;

namespace TD.KCN.WebApi.Host.Controllers.House;

public class PaymentsController : VersionedApiController
{
    [HttpGet("{id:guid}")]
    [AllowAnonymous]
    [OpenApiOperation("Chi tiết địa bàn.", "")]
    public Task<Result<MotelDto>> GetAsync(Guid id)
    {
        return Mediator.Send(new GetMotelRequest(id));
    }
}