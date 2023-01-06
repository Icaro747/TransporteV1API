using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransporteV1API.Modals;

namespace TransporteV1API.Configuretion
{
    public class FuncionarioCofiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Nome).HasMaxLength(64).IsRequired();
            builder.Property(x => x.Sobrenome).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Telefone).HasMaxLength(11).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Cargo).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Salario).IsRequired();
            builder.ToTable("Funcionarios");
        }
    }
}
