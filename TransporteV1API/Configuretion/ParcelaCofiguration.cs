using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransporteV1API.Modals;

namespace TransporteV1API.Configuretion
{
    public class ParcelaCofiguration : IEntityTypeConfiguration<Parcela>
    {
        public void Configure(EntityTypeBuilder<Parcela> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.Data).IsRequired();
            builder.HasOne(x => x.Frete).WithMany(x => x.Parcelas).HasForeignKey(x => x.IdFrete);
            builder.Property(x => x.IdFrete).IsRequired();
            builder.ToTable("Parcelas");
        }
    }
}
