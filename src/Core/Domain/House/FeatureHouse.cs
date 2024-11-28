using System.Xml.Linq;

namespace TD.KCN.WebApi.Domain.House;
public class FeatureHouse : AuditableEntity, IAggregateRoot
{
    public string Name { get; set; } = default!;
    public Guid MotelId { get; set; } = default!;
    public virtual Motel? Motel { get; set; }
    public FeatureHouse(
       string name,
       Guid motelId)
    {
        Name = name;
        MotelId = motelId;
    }

    public FeatureHouse Update(string? name)
    {
        Name = name ?? Name;

        return this;
    }
}
