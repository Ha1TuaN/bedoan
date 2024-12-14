using Mapster;
using System.Text;
using System.Text.RegularExpressions;
using TD.KCN.WebApi.Application.House.FeatureHouses;
using TD.KCN.WebApi.Application.House.ImageHouses;
using TD.KCN.WebApi.Domain.House;

namespace TD.KCN.WebApi.Application.House.Motels;

public class UpdateMotelRequest : IRequest<Result<Guid>>
{
    public Guid Id { get; set; }
    public string? Address { get; set; }
    public string? Type { get; set; }
    public Guid? ProvinceId { get; set; }
    public Guid? DistrictId { get; set; }
    public string? Description { get; set; }
    public decimal? Price { get; set; }
    public decimal? Area { get; set; }
    public decimal? Motel { get; set; }
    public int? BedroomCount { get; set; }
    public int? BathroomCount { get; set; }
    public decimal? Lat { get; set; }
    public decimal? Lng { get; set; }
    public List<UpdateImageHouseRequest>? ImageHouses { get; set; }
    public List<UpdateFeatureHouseRequest>? FeatureHouseRequests { get; set; }
    public string? Features { get; set; }
}

public class UpdateMotelRequestValidator : CustomValidator<UpdateMotelRequest>
{
    public UpdateMotelRequestValidator(IRepository<Motel> repository, IStringLocalizer<UpdateMotelRequestValidator> localizer)
    {

    }

}

public class UpdateMotelRequestHandler : IRequestHandler<UpdateMotelRequest, Result<Guid>>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<Motel> _repository;
    private readonly IRepositoryWithEvents<ImageHouse> _repositoryImg;
    private readonly IRepositoryWithEvents<FeatureHouse> _repositoryFeature;
    private readonly IStringLocalizer<UpdateMotelRequestHandler> _localizer;

    public UpdateMotelRequestHandler(IRepositoryWithEvents<Motel> repository, IRepositoryWithEvents<ImageHouse> repositoryImg, IRepositoryWithEvents<FeatureHouse> repositoryFeature, IStringLocalizer<UpdateMotelRequestHandler> localizer) 
    {
        _repository = repository;
        _repositoryImg = repositoryImg;
        _repositoryFeature = repositoryFeature;
        _localizer = localizer;
    }

    public async Task<Result<Guid>> Handle(UpdateMotelRequest request, CancellationToken cancellationToken)
    {
        var item = await _repository.GetByIdAsync(request.Id, cancellationToken);

        _ = item ?? throw new NotFoundException(string.Format(_localizer["Motel.notfound"], request.Id));

        item.Update(
            request.Address,
            request.Type,
            request.ProvinceId,
            request.DistrictId,
            request.Description,
            request.Price,
            request.Area,
            request.BedroomCount,
            request.BathroomCount,
            request.Lat,
            request.Lng,
            request.Features);

        await _repository.UpdateAsync(item, cancellationToken);
        if (request.ImageHouses != null && request.ImageHouses.Count > 0)
        {
            var allImg = await _repositoryImg.ListAsync(cancellationToken);
            var lstOldImg = allImg.Where(x => x.MotelId == request.Id).ToList();
            var itemDeleteImg = lstOldImg.Where(x => !request.ImageHouses.Any(y => y.Id != null && y.Id == x.Id)).ToList();
            if (itemDeleteImg != null && itemDeleteImg.Count > 0)
                await _repositoryImg.DeleteRangeAsync(itemDeleteImg);
            foreach (var img in request.ImageHouses)
            {
                var old = await _repositoryImg.GetByIdAsync(img.Id);
                if (old != null)
                {
                    old.Update(img.Image, request.Id);
                    await _repositoryImg.UpdateAsync(old, cancellationToken);
                }
                else
                {
                    await _repositoryImg.AddAsync(
                        new ImageHouse(img.Image, request.Id), cancellationToken);
                }

            }
        }
        else
        {
            var listDeleteImg = _repositoryImg.ListAsync(cancellationToken).Result.Where(x => x.MotelId == request.Id).ToList();
            if (listDeleteImg != null && listDeleteImg.Count > 0)
            {
                await _repositoryImg.DeleteRangeAsync(listDeleteImg);
            }
        }

        return Result<Guid>.Success(request.Id);
    }

}