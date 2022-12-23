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
            modelBuilder.ApplyConfiguration(new CamiaoCofiguration());
            modelBuilder.ApplyConfiguration(new SeguroCofiguration());
            modelBuilder.ApplyConfiguration(new FinanciamentoCofiguration());
        }

        public DbSet<Camiao> Camiaos { get; set; }
        public DbSet<Seguro> Seguros { get; set; }
        public DbSet<Financiamento> Financiamentos { get; set; }
    }
}
