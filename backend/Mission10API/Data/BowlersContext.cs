using Microsoft.EntityFrameworkCore;

namespace Mission10API.Data
{
    public class BowlersContext : DbContext
    {
        public BowlersContext(DbContextOptions<BowlersContext> options) : base(options) { } 

        public DbSet<Bowlers> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
