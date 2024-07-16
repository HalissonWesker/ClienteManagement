using ClienteManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClienteManagement.Infrastructure.Data
{
    public class ClienteDbContext : DbContext
    {
        public ClienteDbContext(DbContextOptions<ClienteDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=(localdb)\\MSSQLLocalDB;Database=ClienteDb;Trusted_Connection=True;MultipleActiveResultSets=true",
                    options => options.MigrationsAssembly("ClienteManagement.Infrastructure")
                );
            }
        }
    }
}
