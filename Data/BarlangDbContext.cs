using Microsoft.EntityFrameworkCore;

namespace RCSDolg.Data
{
    public class BarlangDbContext : DbContext
    {
        public BarlangDbContext(DbContextOptions<BarlangDbContext> options) : base(options)
        {
        }
        public DbSet<RCSDolg.Models.Barlang> Barlangok { get; set; } = null!;
    }
}
