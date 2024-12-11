using System.Linq;

namespace TD.KCN.WebApi.Application.Dashboard;
public class GetChartRequest : IRequest<List<ChartDto>>
{
    public string? OwnerId { get; set; }
}

public class GetChartRequestHandler : IRequestHandler<GetChartRequest, List<ChartDto>>
{
    private readonly IReadRepository<Motel> _repository;

    public GetChartRequestHandler(IReadRepository<Motel> repository)
    {
        _repository = repository;
    }

    public async Task<List<ChartDto>> Handle(GetChartRequest request, CancellationToken cancellationToken)
    {
        var houses = await _repository.ListAsync(cancellationToken);

        var chartData = new List<ChartDto>();

        for (int i = 1; i <= 12; i++)
        {
            var filteredHouses = houses
                .Where(x => x.CreatedOn.HasValue && x.CreatedOn.Value.Month == i &&
                            (string.IsNullOrEmpty(request.OwnerId) || x.UserId == request.OwnerId))
                .ToList();

            int totalPost = filteredHouses.Count();
            decimal totalPrice = filteredHouses.Where(x => x.Status == "Đang được thuê").Sum(x => x.Price.GetValueOrDefault());
            int houseRent = filteredHouses.Count(x => x.Status == "Đang được thuê");

            chartData.Add(new ChartDto
            {
                Month = "Tháng " + i,
                TotalPost = totalPost,
                Price = totalPrice,
                HouseRent = houseRent
            });
        }

        return chartData;
    }

}
