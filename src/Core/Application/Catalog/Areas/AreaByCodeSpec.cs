namespace TD.KCN.WebApi.Application.Catalog.Areas;

public class AreaByCodeSpec : SingleResultSpecification<Area>
{
    public AreaByCodeSpec(string? code) =>
        Query.Where(p => p.Code.Equals(code), code is not null);

}