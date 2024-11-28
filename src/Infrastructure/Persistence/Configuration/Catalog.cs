using Finbuckle.MultiTenant.EntityFrameworkCore;
using TD.KCN.WebApi.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TD.KCN.WebApi.Infrastructure.Persistence.Configuration;

public class AreaConfig : IEntityTypeConfiguration<Area>
{
    public void Configure(EntityTypeBuilder<Area> builder)
    {
        builder.IsMultiTenant();
        builder.Property(b => b.Name).HasMaxLength(256);
        builder.Property(b => b.Code).HasMaxLength(256);
        builder.Property(b => b.Description).HasMaxLength(1024);
        builder.HasIndex(b => b.Name);
        builder.ToTable("Areas", SchemaNames.Catalog);
    }
}


public class AttachmentConfig : IEntityTypeConfiguration<Attachment>
{
    public void Configure(EntityTypeBuilder<Attachment> builder)
    {
        builder.IsMultiTenant();
        builder.Property(b => b.Name).HasMaxLength(256);
        builder.Property(b => b.Extension).HasMaxLength(128);
        builder.Property(b => b.Description).HasMaxLength(512);
        builder.Property(b => b.FileURL).HasMaxLength(512);
        builder.HasIndex(b => b.Name);
    }
}

public class CategoryConfig : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.IsMultiTenant();
        builder.Property(b => b.Name).HasMaxLength(256);
        builder.Property(b => b.Code).HasMaxLength(256);
        builder.Property(b => b.Description).HasMaxLength(1024);
        builder.HasIndex(b => b.Name);
        builder.ToTable("Categories", SchemaNames.Catalog);
    }
}
