using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any teachers.
                if (context.teacher.Any())
                {
                    return;   // DB has been seeded
                }

                context.teacher.AddRange(
                    new teacher
                    {
                        id = 1,
                        teachername = "When Harry Met Sally",
                        course = "Romantic Comedy",
                    },

                    new teacher
                    {
                        id = 2,
                        teachername = "Ghostbusters ",
                        course = "chinese"
                    },

                    new teacher
                    {
                        id = 3,
                        teachername = "Ghostbusters22",
                        course = "chinese"
                    },

                    new teacher
                    {
                        id = 4,
                        teachername = "mamamiya",
                        course = "english"
                    }
                );
                context.SaveChanges();

                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Pubisher = "P",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Pubisher = "P",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Pubisher = "P",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Pubisher = "P",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();

            }
        }
    }
}