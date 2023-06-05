using Microsoft.EntityFrameworkCore;
using StatsApp.Data.Models;

namespace StatsApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Statistics> Statistics { get; set; }
    }
}
