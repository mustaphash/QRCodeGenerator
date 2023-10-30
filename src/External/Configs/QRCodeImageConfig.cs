using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class QRCodeImageConfig : IEntityTypeConfiguration<QRCodeImage>
    {
        public void Configure(EntityTypeBuilder<QRCodeImage> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Image)
                .IsRequired();
        }
    }
}
