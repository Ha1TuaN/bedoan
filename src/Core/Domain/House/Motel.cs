using System.Xml.Linq;
using TD.KCN.WebApi.Domain.Identity;

namespace TD.KCN.WebApi.Domain.House;
public class Motel : AuditableEntity, IAggregateRoot
{
    public string Title { get; set; } = default!;
    public string Address { get; set; } = default!;
    public string Type { get; set; } = default!;
    public Guid ProvinceId { get; set; }
    public virtual Area? Province { get; set; }
    public Guid DistrictId { get; set; }
    public virtual Area? District { get; set; }
    public string? Description { get; set; }
    public string? UserId { get; set; }
    public string? UserFullName { get; set; }
    public string? UserAvatar { get; set; }
    public string? UserPhone { get; set; }
    public decimal? Price { get; set; } = default!;
    public decimal? Area { get; set; } = default!;
    public int BedroomCount { get; set; } = default!;
    public int BathroomCount { get; set; } = default!;
    public decimal? Lat { get; set; }
    public decimal? Lng { get; set; }
    public virtual List<ImageHouse> ImageHouses { get; set; }

    public Motel (
        string title,
        string address,
        string type,
        Guid provinceId,
        Guid districtId,
        string? description,
        string? userId,
        string? userFullName,
        string? userAvatar,
        string? userPhone,
        decimal? price,
        decimal? area,
        int bedroomCount,
        int bathroomCount,
        decimal? lat,
        decimal? lng
    )
    {
        Title = title;
        Address = address;
        Type = type;
        ProvinceId = provinceId;
        DistrictId = districtId;
        Description = description;
        UserId = userId;
        Price = price;
        Area = area;
        BedroomCount = bedroomCount;
        BathroomCount = bathroomCount;
        UserAvatar = userAvatar;
        UserPhone = userPhone;
        UserFullName = userFullName;
        Lat = lat;
        Lng = lng;
    }

    public Motel Update(
        string? title,
        string? address,
        string? type,
        Guid? provinceId,
        Guid? districtId,
        string? desciption,
        decimal? price,
        decimal? area,
        int? bedroomCount,
        int? bathroomCount,
        decimal? lat,
        decimal? lng)
    {
        Title = title ?? Title;
        Address = address ?? Address;
        Type = type ?? Type;
        ProvinceId = provinceId ?? ProvinceId;
        DistrictId = districtId ?? DistrictId;
        Description = desciption ?? Description;
        Price = price ?? Price;
        Area = area ?? Area;
        BedroomCount = bedroomCount ?? BedroomCount;
        BathroomCount = bathroomCount ?? BathroomCount;
        Lat = lat ?? Lat;
        Lng = lng ?? Lng;

        return this;
    }
}
