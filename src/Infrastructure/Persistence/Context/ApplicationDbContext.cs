using Finbuckle.MultiTenant;
using TD.KCN.WebApi.Application.Common.Events;
using TD.KCN.WebApi.Application.Common.Interfaces;
using TD.KCN.WebApi.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TD.KCN.WebApi.Domain.House;

namespace TD.KCN.WebApi.Infrastructure.Persistence.Context;

public class ApplicationDbContext : BaseDbContext
{
    public ApplicationDbContext(ITenantInfo currentTenant, DbContextOptions options, ICurrentUser currentUser, ISerializerService serializer, IOptions<DatabaseSettings> dbSettings, IEventPublisher events)
        : base(currentTenant, options, currentUser, serializer, dbSettings, events)
    {
    }
    #region Catalog
    public DbSet<Area> Areas => Set<Area>();
    public DbSet<Attachment> Attachments => Set<Attachment>();
    public DbSet<AttachmentType> AttachmentTypes => Set<AttachmentType>();
    #endregion

    #region House
    public DbSet<Motel> Motels => Set<Motel>();
    public DbSet<ImageHouse> ImageHouse => Set<ImageHouse>();
    public DbSet<FeatureHouse> FeatureHouse => Set<FeatureHouse>();
    public DbSet<Customer> Customer => Set<Customer>();
    public DbSet<Membership> Membership => Set<Membership>();

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}