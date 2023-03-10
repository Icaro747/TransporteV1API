// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransporteV1API.Data;

#nullable disable

namespace TransporteV1API.Migrations
{
    [DbContext(typeof(TransporteContext))]
    [Migration("20230106184523_CorrecaoDeChavesDeDocumentos")]
    partial class CorrecaoDeChavesDeDocumentos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TransporteV1API.Modals.Caminhao", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<int>("Capacidade")
                        .HasColumnType("int");

                    b.Property<string>("Crv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Discricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("OmnLink")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("varchar(7)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Caminhaos", (string)null);
                });

            modelBuilder.Entity("TransporteV1API.Modals.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("NomeContato")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NomeEmpresa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Clientes", (string)null);
                });

            modelBuilder.Entity("TransporteV1API.Modals.DocumentoFun", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("Descritivo")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("IdFuncionario")
                        .HasColumnType("char(36)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("Validade")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("IdFuncionario");

                    b.ToTable("Documentos", (string)null);
                });

            modelBuilder.Entity("TransporteV1API.Modals.Financiamento", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("Banco")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Financiador")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("IdCaminhao")
                        .HasColumnType("char(36)");

                    b.Property<int>("QtdParcelas")
                        .HasColumnType("int");

                    b.Property<float>("ValorMensal")
                        .HasColumnType("float");

                    b.Property<float>("ValorPago")
                        .HasColumnType("float");

                    b.Property<float>("ValorTotal")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdCaminhao")
                        .IsUnique();

                    b.ToTable("Financiamentos", (string)null);
                });

            modelBuilder.Entity("TransporteV1API.Modals.Funcionario", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<float>("Salario")
                        .HasColumnType("float");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios", (string)null);
                });

            modelBuilder.Entity("TransporteV1API.Modals.Gasto", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<Guid>("IdCaminhao")
                        .HasColumnType("char(36)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<float>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdCaminhao");

                    b.ToTable("Gastos", (string)null);
                });

            modelBuilder.Entity("TransporteV1API.Modals.Seguro", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("IdCaminhao")
                        .HasColumnType("char(36)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<float>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdCaminhao")
                        .IsUnique();

                    b.ToTable("Seguros", (string)null);
                });

            modelBuilder.Entity("TransporteV1API.Modals.DocumentoFun", b =>
                {
                    b.HasOne("TransporteV1API.Modals.Funcionario", "Funcionario")
                        .WithMany("Documentos")
                        .HasForeignKey("IdFuncionario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("TransporteV1API.Modals.Financiamento", b =>
                {
                    b.HasOne("TransporteV1API.Modals.Caminhao", "Caminhao")
                        .WithOne("Financiamento")
                        .HasForeignKey("TransporteV1API.Modals.Financiamento", "IdCaminhao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Caminhao");
                });

            modelBuilder.Entity("TransporteV1API.Modals.Gasto", b =>
                {
                    b.HasOne("TransporteV1API.Modals.Caminhao", "Caminhao")
                        .WithMany("Gastos")
                        .HasForeignKey("IdCaminhao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Caminhao");
                });

            modelBuilder.Entity("TransporteV1API.Modals.Seguro", b =>
                {
                    b.HasOne("TransporteV1API.Modals.Caminhao", "Caminhao")
                        .WithOne("Seguro")
                        .HasForeignKey("TransporteV1API.Modals.Seguro", "IdCaminhao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Caminhao");
                });

            modelBuilder.Entity("TransporteV1API.Modals.Caminhao", b =>
                {
                    b.Navigation("Financiamento")
                        .IsRequired();

                    b.Navigation("Gastos");

                    b.Navigation("Seguro")
                        .IsRequired();
                });

            modelBuilder.Entity("TransporteV1API.Modals.Funcionario", b =>
                {
                    b.Navigation("Documentos");
                });
#pragma warning restore 612, 618
        }
    }
}
