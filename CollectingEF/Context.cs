using System.Data.Entity;

namespace Collecting.Infrastructure
{
    public class Context : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
