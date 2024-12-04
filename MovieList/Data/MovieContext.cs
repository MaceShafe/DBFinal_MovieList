using MovieList.Models;
using Microsoft.EntityFrameworkCore;


namespace MovieList.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
        {

        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<GenrePicker> GenrePickers { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<GenrePicker>().ToTable("GenrePicker");
            modelBuilder.Entity<Movie>().ToTable("Movie");
        }

    }
}
