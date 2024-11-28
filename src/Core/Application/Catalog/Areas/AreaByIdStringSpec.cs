namespace TD.KCN.WebApi.Application.Catalog.Areas;

public class AreaByIdStringSpec : Specification<Area, AreaDto>, ISingleResultSpecification<Area>
{
    public AreaByIdStringSpec(string? id)
    {
        Guid idGuid = Guid.Empty;
        Guid.TryParse(id, out idGuid);
        Query.Where(p => p.Id == idGuid);
    }

}