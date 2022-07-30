using AR.Domain;
using Microsoft.EntityFrameworkCore;

namespace AR.Infra
{
    public class ContextPrincipal : DbContext
    {
        
        public ContextPrincipal(DbContextOptions options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;database=AR_Cliente;Integrated Security=True;");

        public DbSet<Cliente> Clientes { get; set; }
    }
}
