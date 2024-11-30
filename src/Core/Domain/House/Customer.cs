using System.Xml.Linq;

namespace TD.KCN.WebApi.Domain.House;
public class Customer : AuditableEntity, IAggregateRoot
{
    public string Name { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public DateTime StartDate { get; set; } = default!;
    public DateTime EndDate { get; set; } = default!;
    public string? File { get; set; }
    public Guid MotelId { get; set; } = default!;
    public virtual Motel? Motel { get; set; }
    public Customer(
       string name,
       string phoneNumber,
       DateTime startDate,
       DateTime endDate,
       string? file,
       Guid motelId)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        StartDate = startDate;
        EndDate = endDate;
        MotelId = motelId;
        File = file;
    }

    public Customer Update(string? name, string? phoneNumber, DateTime? startDate, DateTime? endDate, string? file)
    {
        Name = name ?? Name;
        PhoneNumber = phoneNumber ?? PhoneNumber;
        StartDate = startDate ?? StartDate;
        EndDate = endDate ?? EndDate;
        File = file ?? File;
        return this;
    }
}
