using Microsoft.EntityFrameworkCore;
using TransporteV1API.Configuretion;
using TransporteV1API.Modals;

namespace TransporteV1API.Data
{

    public class TransporteContext : DbContext
    {
        public TransporteContext(DbContextOptions<TransporteContext> opt) : base (opt) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CaminhaoCofiguration());
            modelBuilder.ApplyConfiguration(new SeguroCofiguration());
            modelBuilder.ApplyConfiguration(new FinanciamentoCofiguration());
            modelBuilder.ApplyConfiguration(new GastoCofiguration());
            modelBuilder.ApplyConfiguration(new ClienteCofiguration());
            modelBuilder.ApplyConfiguration(new FuncionarioCofiguration());
            modelBuilder.ApplyConfiguration(new DocumentoFunCofiguration());
        }

        public DbSet<Caminhao> Caminhaos { get; set; }
        public DbSet<Seguro> Seguros { get; set; }
        public DbSet<Financiamento> Financiamentos { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<DocumentoFun> Documentos { get; set; }
    }
}
