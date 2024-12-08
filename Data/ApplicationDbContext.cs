using Microsoft.EntityFrameworkCore;

namespace ProjetoClientes.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // Exemplo de DbSet
        public DbSet<Cliente> Clientes { get; set; }
    }
}
