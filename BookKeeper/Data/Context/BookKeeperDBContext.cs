using Microsoft.EntityFrameworkCore;

namespace BookKeeper.Data
{
    public class BookKeeperDbContext : DbContext
    {
         


        public BookKeeperDbContext(DbContextOptions<BookKeeperDbContext> options)
           : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryType> CategoryTypes { get; set; }
    }
}