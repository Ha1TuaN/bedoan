using Microsoft.AspNetCore.StaticFiles;
using TD.KCN.WebApi.Application.Catalog.Attachments;

namespace TD.WebApi.Host.Controllers.Catalog;

public class AttachmentsController : VersionedApiController
{

    [HttpPost("public")]
    [DisableRequestSizeLimit]
    [OpenApiOperation("Tạo mới đính kèm.", "")]
    public async Task<IActionResult> PostAttachmentPublics([FromForm(Name = "files")] List<IFormFile> files)
    {
        return Ok(await Mediator.Send(new CreateAttachmentsMinioRequest() { Files = files, BucketName = "kcn", Prefix = "public" }));
    }

    [HttpPost("{prefix}")]
    [DisableRequestSizeLimit]
    [OpenApiOperation("Tạo mới đính kèm private.", "")]
    public async Task<IActionResult> PostAttachments([FromForm(Name = "files")] List<IFormFile> files, [FromRoute] string prefix)
    {
        return Ok(await Mediator.Send(new CreateAttachmentsMinioRequest() { Files = files, BucketName = "kcn", Prefix = prefix }));
    }

    [HttpGet("{bucketName}/{*key}")]
    [DisableRequestSizeLimit]
    [AllowAnonymous]
    [OpenApiOperation("Chi tiết đính kèm.", "")]
    /* [AllowAnonymous]*/
    public async Task<IActionResult> SearchAsync(string bucketName, [FromRoute] string key)
    {
        key = Uri.UnescapeDataString(key);
        string s3Object = await Mediator.Send(new GetAttachmentInBucketMinioRequest(bucketName, key));

        // Response.Headers.Add("X-Content-Type-Options", "nosniff");
        return Ok(s3Object);
    }

    private string GetContentType(string path)
    {
        var provider = new FileExtensionContentTypeProvider();
        string? contentType;

        if (!provider.TryGetContentType(path, out contentType))
        {
            contentType = "application/octet-stream";
        }

        return contentType;
    }
}