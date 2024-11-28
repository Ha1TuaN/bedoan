namespace TD.KCN.WebApi.Domain.Catalog;

/// <summary>
/// Loại đính kèm.
/// </summary>
public class AttachmentType : AuditableEntity, IAggregateRoot
{
    public string Name { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }
    public int? SortOrder { get; set; }
    public bool? IsAllowToDownload { get; set; } = false;
    public bool? IsActive { get; set; } = true;

    public AttachmentType(
        string name,
        string? code,
        string? description,
        int? sortOrder,
        bool? isAllowToDownload,
        bool? isActive)
    {
        Name = name;
        Code = code;
        Description = description;
        SortOrder = sortOrder;
        IsAllowToDownload = isAllowToDownload;
        IsActive = isActive;
    }

    public AttachmentType Update(
        string name,
        string? code,
        string? description,
        int? sortOrder,
        bool? isAllowToDownload,
        bool? isActive)
    {
        Name = name ?? Name;
        Code = code ?? Code;
        Description = description ?? Description;
        SortOrder = sortOrder ?? SortOrder;
        IsAllowToDownload = isAllowToDownload ?? IsAllowToDownload;
        IsActive = isActive ?? IsActive;
        return this;
    }
}