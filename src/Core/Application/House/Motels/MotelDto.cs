using TD.KCN.WebApi.Application.House.ImageHouses;
using TD.KCN.WebApi.Application.Identity.Users;

namespace TD.KCN.WebApi.Application.House.Motels;

public class MotelDto : IDto
{
    public DefaultIdType Id { get; set; }
    public string Title { get; set; } = default!;
    public string? Star { get; set; }
    public string Address { get; set; } = default!;
    public string? Type { get; set; } = default!;
    public Guid ProvinceId { get; set; }
    public string? ProvinceName { get; set; }
    public Guid DistrictId { get; set; }
    public string? DistrictName { get; set; }
    public string? Description { get; set; }
    public string? UserId { get; set; }
    public string? UserFullName { get; set; }
    public string? UserAvatar { get; set; }
    public string? UserPhone { get; set; }
    public decimal? Price { get; set; }
    public decimal? Area { get; set; }
    public int? BedroomCount { get; set; }
    public int? BathroomCount { get; set; }
    public decimal? Lat { get; set; }
    public decimal? Lng { get; set; }
    public string? Status { get; set; }
    public List<ImageHouseDto>? ImageHouses { get; set; }
}