using ApiLaboratorial.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiLaboratorial.appDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        public DbSet<TabelaTeste> TabelaTestes { get; set; }
    }
}
