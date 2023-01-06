using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransporteV1API.Modals;

namespace TransporteV1API.Configuretion
{
    public class GastoCofiguration : IEntityTypeConfiguration<Gasto>
    {
        public void Configure(EntityTypeBuilder<Gasto> builder)
        {   
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Id).ValueGeneratedNever();
            builder.Property(x => x.Tipo).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Descricao).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.Data).IsRequired();
            builder.HasOne(x => x.Caminhao).WithMany(x => x.Gastos);
            builder.Property(x => x.IdCamiao).IsRequired();
            builder.ToTable("Gastos");
        }
    }
}
