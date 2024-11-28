namespace TD.KCN.WebApi.Application.Catalog.Areas;

public class AreaDto : IDto
{
    public DefaultIdType Id { get; set; }
    public string Name { get; set; } = default!;
    public string Code { get; set; } = default!;
    public string? ParentCode { get; set; }
    public string? NameWithType { get; set; }
    public string? PathWithType { get; set; }
    public List<AreaDto> Children { get; set; } = new List<AreaDto>();
}