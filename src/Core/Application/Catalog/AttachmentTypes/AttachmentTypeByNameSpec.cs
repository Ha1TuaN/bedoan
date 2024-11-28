namespace TD.KCN.WebApi.Application.Catalog.AttachmentTypes;

public class AccomplishmentTypeByNameSpec : Specification<AttachmentType>, ISingleResultSpecification<AttachmentType>
{
    public AccomplishmentTypeByNameSpec(string name) =>
        Query.Where(b => b.Name == name);
}