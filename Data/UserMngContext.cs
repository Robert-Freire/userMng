using Microsoft.EntityFrameworkCore;
using UserMng.Models;

namespace UserMng.Data
{
    public class UserMngContext : DbContext
    {
        public UserMngContext (DbContextOptions<UserMngContext> options)
            : base(options)
        {
        }

        public DbSet<Group> Group { get; set; }

        public DbSet<UserMng.Models.User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(b => b.DateAdded)
                .HasDefaultValueSql ("datetime('now')");

            modelBuilder.Entity<User>()
                .HasOne(p => p.Group)
                .WithMany(b => b.Users);
        }
    }
}