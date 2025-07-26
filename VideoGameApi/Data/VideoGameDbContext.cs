using Microsoft.EntityFrameworkCore;

namespace VideoGameApi.Data
{
    public class VideoGameDbContext(DbContextOptions<VideoGameDbContext> options) : DbContext(options)
    {
        public DbSet<VideoGame> VideoGames => Set<VideoGame>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame
                {
                    Id = 1,
                    Title = "Spider-Man 2",
                    Platform = "PS5",
                    Developer = "Insomniac Games",
                    Publisher = "Sony"
                },
                new VideoGame
                {
                    Id = 2,
                    Title = "The Legend of Zelda",
                    Platform = "Nintendo Switch",
                    Developer = "Nintento EPD",
                    Publisher = "Nintendo"
                },
                new VideoGame
                {
                    Id = 3,
                    Title = "Cyberpunk 2077",
                    Platform = "PC",
                    Developer = "CD Project Red",
                    Publisher = "CD Project"
                }
            );
        }
    }
}
