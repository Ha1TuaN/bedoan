namespace TD.KCN.WebApi.Application.House.FeatureHouses;

public class FeatureHouseDto : IDto
{
    public DefaultIdType Id { get; set; }
    public string Name { get; set; } = default!;
}