using System.Linq;

namespace TD.KCN.WebApi.Application.Dashboard;
public class GetCardRequest : IRequest<CardDto>
{
    public string? OwnerId { get; set; }
}

public class GetCardRequestHandler : IRequestHandler<GetCardRequest, CardDto>
{
    private readonly IReadRepository<Motel> _repository;

    public GetCardRequestHandler(IReadRepository<Motel> repository)
    {
        _repository = repository;
    }

    public async Task<CardDto> Handle(GetCardRequest request, CancellationToken cancellationToken)
    {
        var houses = await _repository.ListAsync(cancellationToken);

        var card = new CardDto();
        card.TotalHouse = houses.Count(x => x.UserId == request.OwnerId);
        card.HouseNotRent = houses.Count(x => x.Status == "Chưa thuê" && x.UserId == request.OwnerId);
        card.HouseRent = houses.Count(x => x.Status == "Đang được thuê" && x.UserId == request.OwnerId);

        return card;
    }

}
