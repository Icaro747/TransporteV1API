using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Xml.Linq;
using TransporteV1API.Modals;

namespace TransporteV1API.Configuretion
{
    public class ClienteCofiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.NomeEmpresa).HasMaxLength(100).IsRequired();
            builder.Property(x => x.NomeContato).HasMaxLength(100).IsRequired();
            builder.Property(x => x.CNPJ).HasMaxLength(14).IsRequired();
            builder.Property(x => x.Telefone).HasMaxLength(11).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(200).IsRequired();
            builder.ToTable("Clientes");
        }
    }
}
