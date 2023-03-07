//using System.Data.Entity;
global using Microsoft.EntityFrameworkCore;

namespace API_Rest.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder); 
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=APIREST;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<ApiRestClass> MyData { get; set; }

    }
}
