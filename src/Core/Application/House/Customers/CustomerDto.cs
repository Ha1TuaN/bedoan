namespace TD.KCN.WebApi.Application.House.Customers;

public class CustomerDto : IDto
{
    public string Name { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public Guid MotelId { get; set; } = default!;
    public DateTime CreateDate { get; set; }
}