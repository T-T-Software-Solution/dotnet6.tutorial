using _1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _3.Infra;

public class ProvinceConfiguration : IEntityTypeConfiguration<Province>
{
    public void Configure(EntityTypeBuilder<Province> builder)
    {
        builder
            .HasKey(a => a.Id);
            
        builder
            .Property(m => m.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder
            .Property(m => m.Description)
            .HasMaxLength(255);

        builder
            .ToTable("Provinces");
    }
}