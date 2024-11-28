namespace TD.KCN.WebApi.Application.House.Customers;

public class GetCustomerRequest : IRequest<Result<CustomerDto>>
{
    public Guid Id { get; set; }

    public GetCustomerRequest(Guid id) => Id = id;
}

public class CustomerByIdSpec : Specification<Customer, CustomerDto>, ISingleResultSpecification<Customer>
{
    public CustomerByIdSpec(Guid id) =>
        Query.Where(p => p.Id == id);
}

public class GetCustomerRequestHandler : IRequestHandler<GetCustomerRequest, Result<CustomerDto>>
{
    private readonly IRepository<Customer> _repository;
    private readonly IStringLocalizer<GetCustomerRequestHandler> _localizer;

    public GetCustomerRequestHandler(IRepository<Customer> repository, IStringLocalizer<GetCustomerRequestHandler> localizer) => (_repository, _localizer) = (repository, localizer);

    public async Task<Result<CustomerDto>> Handle(GetCustomerRequest request, CancellationToken cancellationToken)
    {
        var item = await _repository.FirstOrDefaultAsync(
            (ISpecification<Customer, CustomerDto>)new CustomerByIdSpec(request.Id), cancellationToken)
        ?? throw new NotFoundException(string.Format(_localizer["Customer.notfound"], request.Id));
        return Result<CustomerDto>.Success(item);

    }
}