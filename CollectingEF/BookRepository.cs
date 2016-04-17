using Collecting;
using Holding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collecting.Infrastructure
{
    class BookRepository : IBookRepository
    {
        public Collecting.Book find(ISBN id)
        {
            throw new NotImplementedException();
        }

        public List<Collecting.Book> findAll()
        {
            throw new NotImplementedException();
        }

        public void remove(Collecting.Book book)
        {
            var entity = new Book() {ID = book.ID.ToString() };
            using (var db = new Context())
            {
                db.Books.Remove(entity);
                db.SaveChanges();
            }
        }

        public void store(Collecting.Book book)
        {
            var entity = new Book() {ID = book.ID.ToString() };
            using (var db = new Context())
            {
                db.Books.Add(entity);
                db.SaveChanges();
            }
        }
    }
}
