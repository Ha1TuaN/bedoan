using System.Security.Cryptography;
using TD.KCN.WebApi.Domain.House;

namespace TD.KCN.WebApi.Application.House.Customers;

public class CreateCustomerRequest : IRequest<Result<Guid>>
{
    public string Name { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public Guid MotelId { get; set; } = default!;
    public DateTime StartDate { get; set; } = default!;
    public DateTime EndDate { get; set; } = default!;
    public string? File {  get; set; }
}

public class CreateCustomerRequestValidator : CustomValidator<CreateCustomerRequest>
{
    public CreateCustomerRequestValidator(IReadRepository<FeatureHouse> repository, IStringLocalizer<CreateCustomerRequestValidator> localizer)
    {

    }

}

public class CreateCustomerRequestHandler : IRequestHandler<CreateCustomerRequest, Result<Guid>>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<Customer> _repository;
    private readonly IRepositoryWithEvents<Motel> _repositoryMotel;

    private readonly IStringLocalizer<CreateCustomerRequestHandler> _localizer;

    public CreateCustomerRequestHandler(IRepositoryWithEvents<Customer> repository, IRepositoryWithEvents<Motel> repositoryMotel, IStringLocalizer<CreateCustomerRequestHandler> localizer) => (_repository, _repositoryMotel, _localizer) = (repository, repositoryMotel, localizer);

    public async Task<Result<Guid>> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
    {
        var customer = new Customer(request.Name, request.PhoneNumber, request.StartDate, request.EndDate, request.File, request.MotelId);
        await _repository.AddAsync(customer, cancellationToken);
        var motel = await _repositoryMotel.GetByIdAsync(request.MotelId);
        if (motel != null)
        {
            motel.UpdateHopDong();
            await _repositoryMotel.UpdateAsync(motel, cancellationToken);
        }

        return Result<Guid>.Success(customer.Id);
    }
}