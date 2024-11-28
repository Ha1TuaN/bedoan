namespace TD.KCN.WebApi.Application.Catalog.Areas;

public class AreaDtoByCodeSpec : Specification<Area, AreaDto>, ISingleResultSpecification<Area>
{
    public AreaDtoByCodeSpec(string? code) =>
        Query.Where(p => p.Code == code, !string.IsNullOrEmpty(code));

}