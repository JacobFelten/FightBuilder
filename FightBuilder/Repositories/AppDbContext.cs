using FightBuilder.Models;
using Microsoft.EntityFrameworkCore;

namespace FightBuilder.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Fighter> Fighters { get; set; }
    }
}
