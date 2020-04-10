using InspirateMobile.Infrastructure.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.IO;

namespace InspirateMobile.Infrastructure.Repository
{
    public class DataBaseContext : DbContext
    {
        public DbSet<CategoriaItem> CategoriaItem { get; set; }
        public DbSet<Interesse> Interesse { get; set; }
        public DbSet<InteresseItem> InteresseItem { get; set; }
        public DbSet<Mensagem> Mensagem { get; set; }
        public DbSet<Oferta> Oferta { get; set; }
        public DbSet<OfertaItem> OfertaItem { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //var config = new Microsoft.Extensions.Configuration.ConfigurationBuilder().(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build());
                //optionsBuilder.UseOracle(config.GetConnectionString("FiapSmartCityConnection"));
                optionsBuilder.UseOracle("Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1522))(CONNECT_DATA = (SERVICE_NAME = xe))); User Id = SYSTEM; Password = SE15#cplTeste;");
                //optionsBuilder.UseOracle("Driver = (Oracle in XEClient); dbq = 111.21.31.99:1521 / XE; Uid = SYSTEM; Pwd = SE15#cplTeste;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
