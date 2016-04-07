using System.Data.Entity;

namespace Collecting.Infrastructure
{
    class Context : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
