using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransporteV1API.Modals;

namespace TransporteV1API.Configuretion
{
    public class SeguroCofiguration : IEntityTypeConfiguration<Seguro>
    {
        public void Configure(EntityTypeBuilder<Seguro> builder)
        {
            builder.HasOne(x => x.camiao).WithOne(x => x.Seguro).HasForeignKey<Seguro>(x => x.IdCamiao); 
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Numero).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.DataVencimento).IsRequired();
        }
    }
}