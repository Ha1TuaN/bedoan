namespace TD.KCN.WebApi.Domain.Catalog;

/// <summary>
/// Danh mục.
/// </summary>
public class Category : AuditableEntity, IAggregateRoot
{
    public string Name { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }

    public Category(
        string name,
        string? code,
        string? description)
    {
        Name = name;
        Code = code;
        Description = description;
    }

    public Category Update(
        string name,
        string? code,
        string? description)
    {
        Name = name;
        Code = code;
        Description = description;
        return this;
    }
}