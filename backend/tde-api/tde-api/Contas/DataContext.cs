
using tde_api.Models;
using Microsoft.EntityFrameworkCore;

namespace tde_api.Contas
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Usuario>? Usuario { get; set; }
        public DbSet<Destino>? Destino { get; set; }
        
        public DbSet<Reserva>? Reservas { get; set; }
    }
}
