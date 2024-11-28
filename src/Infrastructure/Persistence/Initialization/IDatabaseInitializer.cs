using TD.KCN.WebApi.Infrastructure.Multitenancy;

namespace TD.KCN.WebApi.Infrastructure.Persistence.Initialization;

internal interface IDatabaseInitializer
{
    Task InitializeDatabasesAsync(CancellationToken cancellationToken);
    Task InitializeApplicationDbForTenantAsync(TDTenantInfo tenant, CancellationToken cancellationToken);
}