using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransporteV1API.Modals;

namespace TransporteV1API.Configuretion
{
    public class FreteCofiguration : IEntityTypeConfiguration<Frete>
    {
        public void Configure(EntityTypeBuilder<Frete> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Origem).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Destino).HasMaxLength(200).IsRequired();
            builder.Property(x => x.ValorTotal).IsRequired();
            builder.Property(x => x.DataInicio).IsRequired();
            builder.Property(x => x.DataFim).IsRequired();
            builder.HasOne(x => x.Cliente).WithMany(x => x.Fretes).HasForeignKey(x => x.IdCliente);
            builder.Property(x => x.IdCliente).IsRequired();
            builder.HasOne(x => x.Caminhao).WithMany(x => x.Fretes).HasForeignKey(x => x.IdCaminhao);
            builder.Property(x => x.IdCaminhao).IsRequired();
            builder.ToTable("Fretes");
        }
    }
}
