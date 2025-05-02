using IntelliNotes.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IntelliNotes.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}


        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<User>()
                .HasMany(u => u.Notes)
                .WithOne(u => u.User)
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(mb);
        }
    }
}
