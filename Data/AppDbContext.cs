using Microsoft.EntityFrameworkCore;
using TccAplicacao.models;

namespace TccAplicacao.Data
{
    public class AppDbContext : DbContext
    { 
        public DbSet<User> User { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;Port=3306;user=root;password=170816br;database=projetotcc";

            var serverVersion = new MySqlServerVersion(new Version(8,0,34));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}
