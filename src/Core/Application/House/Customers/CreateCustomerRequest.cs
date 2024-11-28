using TD.KCN.WebApi.Domain.House;

namespace TD.KCN.WebApi.Application.House.Customers;

public class CreateCustomerRequest : IRequest<Result<Guid>>
{
    public string Name { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public Guid MotelId { get; set; } = default!;
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
    private readonly IStringLocalizer<CreateCustomerRequestHandler> _localizer;

    public CreateCustomerRequestHandler(IRepositoryWithEvents<Customer> repository, IStringLocalizer<CreateCustomerRequestHandler> localizer) => (_repository, _localizer) = (repository, localizer);

    public async Task<Result<Guid>> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
    {
        var customer = new Customer(request.Name, request.PhoneNumber, request.MotelId);
        await _repository.AddAsync(customer, cancellationToken);

        return Result<Guid>.Success(customer.Id);
    }
}