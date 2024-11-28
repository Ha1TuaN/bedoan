namespace TD.KCN.WebApi.Application.Auditing;

public class AuditListFilter : PaginationFilter
{
    public Guid? UserId { get; set; }
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }
    public string? TableName { get; set; }
    public string? PrimaryKey { get; set; }
    public string? Type { get; set; }

}