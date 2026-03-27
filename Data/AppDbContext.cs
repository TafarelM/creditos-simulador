using Microsoft.EntityFrameworkCore;
using CreditosApp.Models;

namespace CreditosApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ProductoCredito> ProductosCredito { get; set; }
    }
}