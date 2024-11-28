namespace TD.KCN.WebApi.Application.Catalog.Categories;

public class CategoryDto : IDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Code { get; set; }
}