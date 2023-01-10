using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransporteV1API.Modals;

namespace TransporteV1API.Configuretion
{
    public class EquipeCofiguration : IEntityTypeConfiguration<Equipe>
    {
        public void Configure(EntityTypeBuilder<Equipe> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Comissao).IsRequired();
            builder.HasOne(x => x.Frete).WithMany(x => x.Equipes).HasForeignKey(x => x.IdFrete);
            builder.Property(x => x.IdFrete).IsRequired();
            builder.HasOne(x => x.Funcionario).WithMany(x => x.Equipes).HasForeignKey(x => x.IdFuncionario);
            builder.Property(x => x.IdFuncionario).IsRequired();
            builder.ToTable("Equipes");
        }
    }
}
