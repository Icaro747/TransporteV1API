using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransporteV1API.Modals;

namespace TransporteV1API.Configuretion
{
    public class FinanciamentoCofiguration : IEntityTypeConfiguration<Financiamento>
    {
        public void Configure(EntityTypeBuilder<Financiamento> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Financiador).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Banco).HasMaxLength(100).IsRequired();
            builder.Property(x => x.ValorTotal).IsRequired();
            builder.Property(x => x.ValorMensal).IsRequired();
            builder.Property(x => x.ValorPago).IsRequired();
            builder.Property(x => x.QtdParcelas).IsRequired();
            builder.Property(x => x.DataInicio).IsRequired();
            builder.HasOne(x => x.Caminhao).WithOne(x => x.Financiamento).HasForeignKey<Financiamento>(x => x.IdCaminhao);
            builder.Property(x => x.IdCaminhao).IsRequired();
            builder.ToTable("Financiamentos");
        }
    }
}
