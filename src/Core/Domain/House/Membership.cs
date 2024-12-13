namespace TD.KCN.WebApi.Domain.House;
public class Membership : AuditableEntity, IAggregateRoot
{
    public string Name { get; set; } = default!;
    public decimal Price { get; set; }
    public int? CountPost { get; set; }
    public bool? IsVip { get; set; }
    public Membership(string name, decimal price, int? countPost, bool? isVip)
    {
        Name = name;
        Price = price;
        CountPost = countPost;
        IsVip = isVip;
    }

    public Membership Update(string? name, decimal? price, int? countPost, bool? isVip)
    {
        Name = name ?? Name;
        Price = price ?? Price;
        CountPost = countPost ?? CountPost;
        IsVip = isVip ?? IsVip;
        return this;
    }

}
