using System.Data.Entity;
namespace BookShop.Models
{
    public class BookContext : DbContext
    {
        public BookContext() : base("BookShop")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}