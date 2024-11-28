using Asp.Versioning;

namespace TD.KCN.WebApi.Host.Controllers;

[Route("api/[controller]")]
[ApiVersionNeutral]
public class VersionNeutralApiController : BaseApiController
{
}
