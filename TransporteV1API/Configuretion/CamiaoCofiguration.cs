using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransporteV1API.Modals;

namespace TransporteV1API.Configuretion
{
    public class CamiaoCofiguration : IEntityTypeConfiguration<Camiao>
    {
        public void Configure(EntityTypeBuilder<Camiao> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Placa).HasMaxLength(7).IsRequired();
            builder.Property(x=> x.Tipo).HasMaxLength(50).IsRequired();
            builder.Property(x => x.OMNLink).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Capacidade).IsRequired();
            builder.Property(x => x.Discricao).HasMaxLength(200);
            builder.ToTable("Camiaos");
        }
    }
}
