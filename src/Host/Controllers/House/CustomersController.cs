using TD.KCN.WebApi.Application.House.Customers;

namespace TD.KCN.WebApi.Host.Controllers.House;

public class CustomersController : VersionedApiController
{
    [HttpPost("search")]
    [AllowAnonymous]
    [OpenApiOperation("Danh sách địa bàn.", "")]
    public Task<PaginationResponse<CustomerDto>> SearchAsync(SearchCustomersRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpGet("{id:guid}")]
    [AllowAnonymous]
    [OpenApiOperation("Chi tiết địa bàn.", "")]
    public Task<Result<CustomerDto>> GetAsync(Guid id)
    {
        return Mediator.Send(new GetCustomerRequest(id));
    }

    [HttpPost]
    [MustHavePermission(TDAction.Manage, TDResource.Customers)]
    [OpenApiOperation("Tạo mới địa bàn.", "")]
    public Task<Result<Guid>> CreateAsync(CreateCustomerRequest request)
    {
        return Mediator.Send(request);
    }

    [HttpPut("{id:guid}")]
    [MustHavePermission(TDAction.Manage, TDResource.Customers)]
    [OpenApiOperation("Cập nhật địa bàn.", "")]
    public async Task<ActionResult<Guid>> UpdateAsync(UpdateCustomerRequest request, Guid id)
    {
        return id != request.Id
            ? BadRequest()
            : Ok(await Mediator.Send(request));
    }

    [HttpDelete("{id:guid}")]
    [MustHavePermission(TDAction.Manage, TDResource.Customers)]
    [OpenApiOperation("Xóa địa bàn.", "")]
    public Task<Result<Guid>> DeleteAsync(Guid id)
    {
        return Mediator.Send(new DeleteCustomerRequest(id));
    }

}