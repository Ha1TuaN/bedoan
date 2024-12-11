using TD.KCN.WebApi.Application.Dashboard;
namespace TD.KCN.WebApi.Host.Controllers.Dashboard;

public class DashboardController : VersionedApiController
{
    [HttpPost("card")]
    [AllowAnonymous]
    [OpenApiOperation("Get statistics for the dashboard.", "")]
    public Task<CardDto> SearchAsync(GetCardRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpPost("chart")]
    [AllowAnonymous]
    [OpenApiOperation("Get statistics for the dashboard.", "")]
    public Task<List<ChartDto>> SearchAsync(GetChartRequest request)
    {
        return Mediator.Send(request);
    }
}
