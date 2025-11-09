using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class WebAPIContext : DbContext
    {
        public WebAPIContext(DbContextOptions<WebAPIContext> options)
            : base(options)
        {
        }
        // Define your DbSets here. For example:
        // public DbSet<YourEntity> YourEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Author = "J.R.R. Tolkien", Title = "The Hobbit", YearPublished = 1937 },
                new Book { Id = 2, Author = "George Orwell", Title = "1984", YearPublished = 1949 },
                new Book { Id = 3, Author = "Harper Lee", Title = "To Kill a Mockingbird", YearPublished = 1960 }
            );

        }

        public DbSet<Book> Books { get; set; }
    }
}
