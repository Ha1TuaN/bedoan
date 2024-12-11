using Mapster;
using System.Text;
using System.Text.RegularExpressions;
using TD.KCN.WebApi.Application.House.FeatureHouses;
using TD.KCN.WebApi.Application.House.ImageHouses;
using TD.KCN.WebApi.Domain.House;

namespace TD.KCN.WebApi.Application.House.Memberships;

public class UpdateMembershipRequest : IRequest<Result<Guid>>
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public decimal Price { get; set; }
    public string? MonthlyNewsletter { get; set; }
    public string? Utilities { get; set; }
}

public class UpdateMembershipRequestValidator : CustomValidator<UpdateMembershipRequest>
{
    public UpdateMembershipRequestValidator(IRepository<Membership> repository, IStringLocalizer<UpdateMembershipRequestValidator> localizer)
    {

    }

}

public class UpdateMembershipRequestHandler : IRequestHandler<UpdateMembershipRequest, Result<Guid>>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<Membership> _repository;
    private readonly IStringLocalizer<UpdateMembershipRequestHandler> _localizer;

    public UpdateMembershipRequestHandler(IRepositoryWithEvents<Membership> repository, IStringLocalizer<UpdateMembershipRequestHandler> localizer) 
    {
        _repository = repository;
        _localizer = localizer;
    }

    public async Task<Result<Guid>> Handle(UpdateMembershipRequest request, CancellationToken cancellationToken)
    {
        var item = await _repository.GetByIdAsync(request.Id, cancellationToken);

        _ = item ?? throw new NotFoundException(string.Format(_localizer["Membership.notfound"], request.Id));

        item.Update(
           request.Name,
           request.Price,
           request.MonthlyNewsletter,
           request.Utilities);

        await _repository.UpdateAsync(item, cancellationToken);

        return Result<Guid>.Success(request.Id);
    }

}