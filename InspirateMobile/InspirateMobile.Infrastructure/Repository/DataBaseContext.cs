using InspirateMobile.Infrastructure.Entidades;
using Microsoft.EntityFrameworkCore;
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
                optionsBuilder.UseOracle("Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = oracle.fiap.com.br)(PORT = 1521)))(CONNECT_DATA = (SID = orcl))); Persist Security Info = True; User ID = xxxxxx; Password = xxxxx; Pooling = True; Connection Timeout = 60; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
