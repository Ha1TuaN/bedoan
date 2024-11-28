using System.Xml.Linq;

namespace TD.KCN.WebApi.Domain.House;
public class Customer : AuditableEntity, IAggregateRoot
{
    public string Name { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public Guid MotelId { get; set; } = default!;
    public virtual Motel? Motel { get; set; }
    public Customer(
       string name,
       string phoneNumber,
       Guid motelId)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        MotelId = motelId;
    }

    public Customer Update(string? name, string? phoneNumber)
    {
        Name = name ?? Name;
        PhoneNumber = phoneNumber ?? PhoneNumber;

        return this;
    }
}
