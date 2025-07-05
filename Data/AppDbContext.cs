using Microsoft.EntityFrameworkCore;
using MacLancheFelizFabricio.Models;

namespace MacLancheFelizFabricio.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
