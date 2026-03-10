using Microsoft.EntityFrameworkCore;
using RazorPagesBook.Data;

namespace RazorPagesBooks.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesBookContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesBookContext>>()))
        {
            if (context == null || context.Book == null)
            {
                throw new ArgumentNullException("Null RazorPagesBookContext");
            }

            // Look for any movies.
            if (context.Book.Any())
            {
                return;   // DB has been seeded
            }

            context.Book.AddRange(

                new Book
                {
                    Title = "The Remains of the Day",
                    Author = "Kazuo Ishiguro",
                    Genre = "Historical",
                    FirstPublished = DateTime.Parse("1989-5-12"),
                    IBSN = 0679731725
                },

                new Book
                {
                    Title = "Never Let Me Go",
                    Author = "Kazuo Ishiguro",
                    Genre = "Science Fiction",
                    FirstPublished = DateTime.Parse("2005-4-12"),
                    IBSN = 9781400078776
                },

                new Book
                {
                    Title = "The Bookshop",
                    Author = "Penelope Fitzgerald",
                    Genre = "Historical",
                    FirstPublished = DateTime.Parse("1978-1-5"),
                    IBSN = 0395869463
                }



            );
            context.SaveChanges();
        }
    }
}