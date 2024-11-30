namespace TD.KCN.WebApi.Application.House.Customers;

public class UpdateCustomerRequest : IRequest<Result<Guid>>
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? File {  get; set; }

}

public class UpdateCustomerRequestValidator : CustomValidator<UpdateCustomerRequest>
{
    public UpdateCustomerRequestValidator(IRepository<Customer> repository, IStringLocalizer<UpdateCustomerRequestValidator> localizer)
    {

    }

}

public class UpdateCustomerRequestHandler : IRequestHandler<UpdateCustomerRequest, Result<Guid>>
{
    // Add Domain Events automatically by using IRepositoryWithEvents
    private readonly IRepositoryWithEvents<Customer> _repository;
    private readonly IStringLocalizer<UpdateCustomerRequestHandler> _localizer;

    public UpdateCustomerRequestHandler(IRepositoryWithEvents<Customer> repository, IStringLocalizer<UpdateCustomerRequestHandler> localizer) =>
        (_repository, _localizer) = (repository, localizer);

    public async Task<Result<Guid>> Handle(UpdateCustomerRequest request, CancellationToken cancellationToken)
    {
        var item = await _repository.GetByIdAsync(request.Id, cancellationToken);

        _ = item ?? throw new NotFoundException(string.Format(_localizer["Customer.notfound"], request.Id));

        item.Update(request.Name, request.PhoneNumber, request.StartDate, request.EndDate, request.File);

        await _repository.UpdateAsync(item, cancellationToken);

        return Result<Guid>.Success(request.Id);
    }

}