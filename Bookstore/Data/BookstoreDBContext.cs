namespace Bookstore.Data
{
    using Bookstore.Models;
    using Microsoft.EntityFrameworkCore;

    public class BookstoreDBContext : DbContext
    {
        public BookstoreDBContext(DbContextOptions<BookstoreDBContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Brave New World",
                    Author = "Aldous Huxley",
                    Price = 9.99m,
                    Genre = "Dystopian"
                },
                new Book
                {
                    Id = 2,
                    Title = "The Catcher in the Rye",
                    Author = "J.D. Salinger",
                    Price = 8.49m,
                    Genre = "Fiction"
                },
                new Book
                {
                    Id = 3,
                    Title = "Pride and Prejudice",
                    Author = "Jane Austen",
                    Price = 6.99m,
                    Genre = "Romance"
                },
                new Book
                {
                    Id = 4,
                    Title = "Moby Dick",
                    Author = "Herman Melville",
                    Price = 11.50m,
                    Genre = "Adventure"
                },
                new Book
                {
                    Id = 5,
                    Title = "The Alchemist",
                    Author = "Paulo Coelho",
                    Price = 9.49m,
                    Genre = "Philosophical"
                },
                new Book
                {
                    Id = 6,
                    Title = "War and Peace",
                    Author = "Leo Tolstoy",
                    Price = 12.99m,
                    Genre = "Historical Fiction"
                },
                new Book
                {
                    Id = 7,
                    Title = "Fahrenheit 451",
                    Author = "Ray Bradbury",
                    Price = 7.49m,
                    Genre = "Dystopian"
                },
                new Book
                {
                    Id = 8,
                    Title = "The Hobbit",
                    Author = "J.R.R. Tolkien",
                    Price = 8.99m,
                    Genre = "Fantasy"
                }
            );

        }
    }

}
