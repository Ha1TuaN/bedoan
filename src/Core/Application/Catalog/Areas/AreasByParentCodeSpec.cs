namespace TD.KCN.WebApi.Application.Catalog.Areas;

public class AreasByParentCodeSpec : Specification<Area, AreaDto>
{
    public AreasByParentCodeSpec(string? parentCode) =>
         Query.Where(p => p.ParentCode == parentCode);

}