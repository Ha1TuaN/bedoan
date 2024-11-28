using TD.KCN.WebApi.Application.Common.Minio;

namespace TD.KCN.WebApi.Application.Catalog.Attachments;

public class GetAttachmentInBucketMinioRequest : IRequest<string>
{
    public string BucketName { get; set; }
    public string Key { get; set; }

    public GetAttachmentInBucketMinioRequest(string bucketName, string key)
    {
        BucketName = bucketName;
        Key = key;
    }
}

public class GetAttachmentInBucketMinioRequestHandler : IRequestHandler<GetAttachmentInBucketMinioRequest, string>
{
    private readonly IMinioService _file;

    public GetAttachmentInBucketMinioRequestHandler(IMinioService file) => _file = file;

    public async Task<string> Handle(GetAttachmentInBucketMinioRequest request, CancellationToken cancellationToken)
    {
        return await _file.GetUrlFileAsync(request.BucketName, request.Key);
    }
}