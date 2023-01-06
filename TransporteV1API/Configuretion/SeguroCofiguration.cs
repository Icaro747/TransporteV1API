using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransporteV1API.Modals;

namespace TransporteV1API.Configuretion
{
    public class SeguroCofiguration : IEntityTypeConfiguration<Seguro>
    {
        public void Configure(EntityTypeBuilder<Seguro> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).ValueGeneratedNever();
            builder.Property(x => x.Numero).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.DataVencimento).IsRequired();
            builder.HasOne(x => x.Caminhao).WithOne(x => x.Seguro).HasForeignKey<Seguro>(x => x.IdCaminhao);
            builder.Property(x => x.IdCaminhao).IsRequired();
            builder.ToTable("Seguros");
        }
    }
}