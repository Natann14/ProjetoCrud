using Microsoft.EntityFrameworkCore;
using ProjetoCrudPET.Controllers;

namespace ProjetoCrudPET.Models
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
            var connectionString = Configuration.GetConnectionString("WebApiDatabase");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected DbSet<Cliente>? Clientes { get; set; }
        protected DbSet<Gerente>? Gerentes { get; set; }
    }
}
