using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransporteV1API.Modals;

namespace TransporteV1API.Configuretion
{
    public class CaminhaoCofiguration : IEntityTypeConfiguration<Caminhao>
    {
        public void Configure(EntityTypeBuilder<Caminhao> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Nome).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Placa).HasMaxLength(7).IsRequired();
            builder.Property(x => x.Tipo).HasMaxLength(50).IsRequired();
            builder.Property(x => x.OmnLink).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Crv).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Capacidade);
            builder.Property(x => x.Discricao).HasMaxLength(200);
            builder.ToTable("Caminhaos");
        }
    }
}
