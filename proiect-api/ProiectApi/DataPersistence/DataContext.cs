using Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataPersistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<StickyNote> StickyNotes { get; set; }
    }
}
