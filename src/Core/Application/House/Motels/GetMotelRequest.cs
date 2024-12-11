using TD.KCN.WebApi.Application.Identity.Users;

namespace TD.KCN.WebApi.Application.House.Motels;

public class GetMotelRequest : IRequest<Result<MotelDto>>
{
    public Guid Id { get; set; }

    public GetMotelRequest(Guid id) => Id = id;
}

public class MotelByIdSpec : Specification<Motel, MotelDto>, ISingleResultSpecification<Motel>
{
    public MotelByIdSpec(Guid id) =>
        Query.Where(p => p.Id == id);
}

public class GetMotelRequestHandler : IRequestHandler<GetMotelRequest, Result<MotelDto>>
{
    private readonly IRepository<Motel> _repository;
    private readonly IUserService _userService;

    private readonly IStringLocalizer<GetMotelRequestHandler> _localizer;

    public GetMotelRequestHandler(IRepository<Motel> repository, IUserService userService, IStringLocalizer<GetMotelRequestHandler> localizer) => (_repository, _userService, _localizer) = (repository, userService, localizer);

    public async Task<Result<MotelDto>> Handle(GetMotelRequest request, CancellationToken cancellationToken)
    {
        var item = await _repository.FirstOrDefaultAsync(
            (ISpecification<Motel, MotelDto>)new MotelByIdSpec(request.Id), cancellationToken)
        ?? throw new NotFoundException(string.Format(_localizer["Motel.notfound"], request.Id));
        var user = await _userService.GetAsync(item.UserId, cancellationToken);
        item.UserAvatar = user.ImageUrl;
        item.UserPhone = user.PhoneNumber;
        item.UserFullName = user.FullName;
        return Result<MotelDto>.Success(item);

    }
}