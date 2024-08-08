using Razor.Data;
using Microsoft.EntityFrameworkCore;

namespace Razor.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorContext(serviceProvider.GetRequiredService<DbContextOptions<RazorContext>>()))
        {
            if(context == null || context.Movie == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            if (context.Movie.Any())
            {
                return;   // Bu o dimeydiki DB-de data var onsuzda. Nese xsusi qayda qoyusansa ozun bilersen
            }

            context.Movie.AddRange(
                new Movie
                {
                    Title = "Dedpul and Volverin",
                    ReleaseDate = DateTime.Parse("2024-7-25"),
                    Genre = "Action Comedy",
                    Price = 9.99M
                },

                new Movie
                {
                    Title = "Looper",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Zamanda seyahet zad herseyden var",
                    Price = 7.43M
                },

                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M
                },

                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}
