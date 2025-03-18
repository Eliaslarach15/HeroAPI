using Microsoft.EntityFrameworkCore;
using HeroApi.Models;

namespace HeroApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Hero> Heroes { get; set; }
    }
}
