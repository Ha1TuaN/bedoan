namespace TD.KCN.WebApi.Application.Catalog.AttachmentTypes;

public class AttachmentTypeDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Code { get; set; }
    public string? Description { get; set; }
    public int? SortOrder { get; set; }
    public bool? IsAllowToDownload { get; set; } = false;
    public bool? IsActive { get; set; } = true;
}