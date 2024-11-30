namespace TD.KCN.WebApi.Application.House.Customers;

public class CustomerDto : IDto
{
    public string Name { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public Guid MotelId { get; set; } = default!;
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime CreateDate { get; set; }
    public string? File { get; set; }
}