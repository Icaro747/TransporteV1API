using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TransporteV1API.Modals;

namespace TransporteV1API.Configuretion
{
    public class DocumentoFunCofiguration : IEntityTypeConfiguration<DocumentoFun>
    {
        public void Configure(EntityTypeBuilder<DocumentoFun> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            builder.Property(x => x.Tipo).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Documento).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Descritivo).HasMaxLength(300).IsRequired();
            builder.Property(x => x.Validade);
            builder.HasOne(x => x.Funcionario).WithMany(x => x.Documentos).HasForeignKey(x => x.IdFuncionario);
            builder.Property(x => x.IdFuncionario).IsRequired();
            builder.ToTable("Documentos");
        }
    }
}
