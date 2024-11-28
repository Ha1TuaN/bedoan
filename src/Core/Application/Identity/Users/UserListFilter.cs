namespace TD.KCN.WebApi.Application.Identity.Users;

public class UserListFilter : PaginationFilter
{
    public bool? IsActive { get; set; }
    public Guid? OrganizationUnitId { get; set; }
}