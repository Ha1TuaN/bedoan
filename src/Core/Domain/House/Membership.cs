using System.Xml.Linq;

namespace TD.KCN.WebApi.Domain.House;
public class Membership : AuditableEntity, IAggregateRoot
{
    public string Name { get; set; } = default!;
    public decimal Price { get; set; }
    public string? MonthlyNewsletter { get; set; }
    public string? Utilities { get; set; }
    public Membership(string name, decimal price, string? monthlyNewsletter, string? utilities)
    {
        Name = name;
        Price = price;
        MonthlyNewsletter = monthlyNewsletter;
        Utilities = utilities;
    }

    public Membership Update(string? name, decimal? price, string? monthlyNewsletter, string? utilities)
    {
        Name = name ?? Name;
        Price = price ?? Price;
        MonthlyNewsletter = monthlyNewsletter ?? MonthlyNewsletter;
        Utilities = utilities ?? Utilities;
        return this;
    }

}
