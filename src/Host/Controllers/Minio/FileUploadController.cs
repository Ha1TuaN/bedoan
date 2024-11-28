namespace TD.KCN.WebApi.Host.Controllers.Minio;
public class FileUploadController : VersionNeutralApiController
{
    private readonly IWebHostEnvironment _environment;
    private readonly IHttpContextAccessor _httpContextAccessor;
    public FileUploadController(IWebHostEnvironment environment, IHttpContextAccessor httpContextAccessor)
    {
        _environment = environment;
        _httpContextAccessor = httpContextAccessor;
    }

    [HttpPost]
    [AllowAnonymous]
    ////[MustHavePermission(TDAction.Create, TDResource.Minios)]
    [OpenApiOperation("upload file.", "")]
    public async Task<ActionResult<List<string>>> UploadFiles(List<IFormFile> files)
    {
        var listImage = new List<string>();

        foreach (var file in files)
        {
            if (file == null) throw new ArgumentNullException(nameof(file));
            string contentPath = _environment.ContentRootPath;
            string uploadPath = Path.Combine(contentPath, "Uploads");
            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }

            string fileExtension = Path.GetExtension(file.FileName);

            string fileName = $"{Guid.NewGuid()}{fileExtension}";
            string filePath = Path.Combine(uploadPath, fileName);

            await using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // Generate the URL for the file
            var request = _httpContextAccessor.HttpContext.Request;
            string baseUrl = $"{request.Scheme}://{request.Host.Value}";
            string fileUrl = Path.Combine(baseUrl, "Uploads", fileName).Replace("\\", "/");

            listImage.Add(fileUrl);
        }

        return Ok(listImage);
    }
}
