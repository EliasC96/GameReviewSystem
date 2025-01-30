using Microsoft.EntityFrameworkCore;
using GameReviewSystem.Models;

namespace GameReviewSystem.Data
{
    public class GameReviewSystemContext : DbContext
    {
        public GameReviewSystemContext(DbContextOptions<GameReviewSystemContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Game { get; set; } = default!;
        public DbSet<Genre> Genre { get; set; } = default!;
        public DbSet<Platform> Platform { get; set; } = default!;
        public DbSet<Review> Review { get; set; } = default!;
        public DbSet<GamePlatform> GamePlatform { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GamePlatform>()
                .HasKey(gp => new { gp.GameId, gp.PlatformId }); // Define composite key

            modelBuilder.Entity<GamePlatform>()
                .HasOne(gp => gp.Game)
                .WithMany(g => g.GamePlatforms)
                .HasForeignKey(gp => gp.GameId);

            modelBuilder.Entity<GamePlatform>()
                .HasOne(gp => gp.Platform)
                .WithMany(p => p.GamePlatforms)
                .HasForeignKey(gp => gp.PlatformId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
