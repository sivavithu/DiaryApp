using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "First Entry",
                    Content = "This is the content of the first diary entry.",
                    Creation = new DateTime(2025, 7, 22, 9, 0, 0) // Hardcoded DateTime
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Second Entry",
                    Content = "This is the content of the second diary entry.",
                    Creation = new DateTime(2025, 7, 22, 10, 0, 0) // Hardcoded DateTime
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Third Entry",
                    Content = "This is the content of the third diary entry.",
                    Creation = new DateTime(2025, 7, 22, 11, 0, 0) // Hardcoded DateTime
                }
            );
        }
    }
}