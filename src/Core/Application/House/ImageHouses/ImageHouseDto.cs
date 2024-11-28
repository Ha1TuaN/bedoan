namespace TD.KCN.WebApi.Application.House.ImageHouses;

public class ImageHouseDto : IDto
{
    public DefaultIdType Id { get; set; }
    public string Image { get; set; } = default!;
}