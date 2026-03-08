using Microsoft.EntityFrameworkCore;
using jadt.Domain.Entities.Auth;
using jadt.Domain.Entities.DailyKanban;

namespace jadt.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<DayEntry> DayEntries { get; set; }
        public DbSet<DailyTask> DailyTasks { get; set; }
        public DbSet<RecurrenceRule> RecurrenceRules { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
    }
}
