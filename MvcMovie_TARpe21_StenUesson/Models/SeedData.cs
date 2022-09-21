using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie_TARpe21_StenUesson.Data;
using MvcMovie_TARpe21_StenUesson.Models;
using System;
using System.Linq;

namespace MvcMovie_TARpe21_StenUesson
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovie_TARpe21_StenUessonContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovie_TARpe21_StenUessonContext>>()))
            {
                // Look for any movies.
                if (!context.Movie.Any())
                {

                    AddMovies(context);   // DB has been seeded
                }
                context.SaveChanges();
            }
        }

        private static void AddMovies(MvcMovie_TARpe21_StenUessonContext context)
        {
            context.Movie.AddRange(
                 new Movies
                 {
                     Title = "how to train your dragon",
                     ReleaseDate = DateTime.Parse("2-4-2010"),
                     Genre = "Adventure Children's film",
                     Rating = "PG",
                     Price = 10
                 },

                 new Movies
                 {
                     Title = "Percy Jackson The Lightning thief",
                     ReleaseDate = DateTime.Parse("14-2-2010"),
                     Genre = "Adventure Fantasy",
                     Rating = "PG",
                     Price = 10
                 },

                 new Movies
                 {
                     Title = "hobbs and shaw",
                     ReleaseDate = DateTime.Parse("2-8-2019"),
                     Genre = "Buddy cop Action",
                     Rating = "PG-13",
                     Price = 15

                 },

                 new Movies
                 {
                     Title = "IT",
                     ReleaseDate = DateTime.Parse("8-9-2017"),
                     Genre = "Thriller mystery",
                     Rating = "R",
                     Price = 12
                 }
             );
        }
    }
}