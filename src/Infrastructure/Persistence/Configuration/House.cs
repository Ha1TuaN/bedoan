using Finbuckle.MultiTenant.EntityFrameworkCore;
using TD.KCN.WebApi.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TD.KCN.WebApi.Domain.House;

namespace TD.KCN.WebApi.Infrastructure.Persistence.Configuration;

public class MotelConfig : IEntityTypeConfiguration<Motel>
{
    public void Configure(EntityTypeBuilder<Motel> builder)
    {
        builder.IsMultiTenant();
        builder.ToTable("Motels", SchemaNames.House);

        builder.HasOne(h => h.Province)
               .WithMany()
               .HasForeignKey(h => h.ProvinceId)
               .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(h => h.District)
               .WithMany()
               .HasForeignKey(h => h.DistrictId)
               .OnDelete(DeleteBehavior.NoAction);
    }
}

public class ImageHouseConfig : IEntityTypeConfiguration<ImageHouse>
{
    public void Configure(EntityTypeBuilder<ImageHouse> builder)
    {
        builder.IsMultiTenant();
        builder.ToTable("ImageHouses", SchemaNames.House);

        builder.HasOne(img => img.Motel)
               .WithMany(x => x.ImageHouses)
               .HasForeignKey(img => img.MotelId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}

public class FeatureHouseConfig : IEntityTypeConfiguration<FeatureHouse>
{
    public void Configure(EntityTypeBuilder<FeatureHouse> builder)
    {
        builder.IsMultiTenant();
        builder.ToTable("FeatureHouses", SchemaNames.House);

        builder.HasOne(img => img.Motel)
               .WithMany()
               .HasForeignKey(img => img.MotelId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}

public class CustomerConfig : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.IsMultiTenant();
        builder.ToTable("Customers", SchemaNames.House);

        builder.HasOne(img => img.Motel)
               .WithMany()
               .HasForeignKey(img => img.MotelId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}

public class MembershipConfig : IEntityTypeConfiguration<Membership>
{
    public void Configure(EntityTypeBuilder<Membership> builder)
    {
        builder.IsMultiTenant();
        builder.ToTable("Memberships", SchemaNames.House);
    }
}

