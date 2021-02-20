using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreTyler.Models
{
    public class SeedData
    {
        // IApplicationBuilder holds data we need
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BooksDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BooksDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(

                    new Books
                    {
                        Title = "Unbroken",
                        AuthorFirstName = "Laura",
                        AuthorLastName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-3642117466",
                        Price = 13.33,
                        Category = "Non-Fiction",
                        Classification = "Historical"
                    },

                    new Books
                    {
                        Title = "Les Miserables",
                        AuthorFirstName = "Victor",
                        AuthorLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Price = 9.95,
                        Category = "Non-Fiction",
                        Classification = "Historical"
                    },

                    new Books
                    {
                        Title = "Deep Work",
                        AuthorFirstName = "Cal",
                        AuthorLastName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Price = 14.99,
                        Category = "Non-Fiction",
                        Classification = "Self-Help"
                    },

                    new Books
                    {
                        Title = "Team of Rivals",
                        AuthorFirstName = "Doris",
                        AuthorMInitial = "K",
                        AuthorLastName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Price = 14.59,
                        Category = "Non-Fiction",
                        Classification = "Biography"
                    },

                    new Books
                    {
                        Title = "The Snowball",
                        AuthorFirstName = "Alice",
                        AuthorLastName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Price = 14.99,
                        Category = "Non-Fiction",
                        Classification = "Biography"
                    },

                    new Books
                    {
                        Title = "American Ulysses",
                        AuthorFirstName = "Ronald",
                        AuthorMInitial = "C",
                        AuthorLastName = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Price = 11.61,
                        Category = "Non-Fiction",
                        Classification = "Biography"
                    },

                    new Books
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Price = 15.95,
                        Category = "Fiction",
                        Classification = "Historical Fiction"
                    },

                    new Books
                    {
                        Title = "It's Your Ship",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Price = 21.66,
                        Category = "Non-Fiction",
                        Classification = "Self-Help"
                    },

                    new Books
                    {
                        Title = "The Virgin Way",
                        AuthorFirstName = "Richard",
                        AuthorLastName = "Brandson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Price = 29.16,
                        Category = "Non-Fiction",
                        Classification = "Business"
                    },

                    new Books
                    {
                        Title = "Sycamore Row",
                        AuthorFirstName = "John",
                        AuthorLastName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Price = 15.03,
                        Category = "Non-Fiction",
                        Classification = "Thrillers"
                    });
             }

            context.SaveChanges();
         }
    }
}