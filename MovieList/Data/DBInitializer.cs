using System.Diagnostics;
using System;
using MovieList.Models;
using System.Linq;


namespace MovieList.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MovieContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Movies.Any())
            {
                return;   // DB has been seeded
            }

            var Movies = new Movie[]
            {
            new Movie{MovieName="Avengers",ReleaseDate=DateTime.Parse("2012-05-04")},
            new Movie{MovieName="Sonic the Hedgehog 2",ReleaseDate=DateTime.Parse("2022-04-08")},
            new Movie{MovieName="Sonic the Hedgehog 3",ReleaseDate=DateTime.Parse("2024-12-20")},
            new Movie{MovieName="Everything Everywhere All At Once",ReleaseDate=DateTime.Parse("2022-08-04")},
            new Movie{MovieName="The Godfather",ReleaseDate=DateTime.Parse("1972-3-14")}


            };
            foreach (Movie s in Movies)
            {
                context.Movies.Add(s);
            }
            context.SaveChanges();

            var Genres = new Genre[]
            {
            
            new Genre{GenreID=001,GenreName="Comedy"},
            new Genre{GenreID=002,GenreName="Action"},
            new Genre{GenreID=003,GenreName="Sci-Fi"},
            new Genre{GenreID=004,GenreName="Drama"},
            new Genre{GenreID=005,GenreName="Superhero"}


            };
            foreach (Genre c in Genres)
            {
                context.Genres.Add(c);
            }
            context.SaveChanges();

            var genrePickers = new GenrePicker[]
            {
            new GenrePicker{MovieID=1,GenreID=002},
            new GenrePicker{MovieID=1,GenreID=001},
            new GenrePicker{MovieID=1,GenreID=005},
            new GenrePicker{MovieID=2,GenreID=002},
            new GenrePicker{MovieID=2,GenreID=001},
            new GenrePicker{MovieID=3,GenreID=002},
            new GenrePicker{MovieID=3,GenreID=001},
            new GenrePicker{MovieID=4,GenreID=003},
            new GenrePicker{MovieID=5,GenreID=004}





            };
            foreach (Genre e in Genres)
            {
                context.Genres.Add(e);
            }
            context.SaveChanges();
        }
    }
}
