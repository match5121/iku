using Holding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collecting.Infrastructure
{
    public class Amazon : IBookRepository
    {
        public Book Find(ISBN id)
        {
            throw new NotImplementedException();
        }

        public List<Book> FindAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Book book)
        {
            throw new NotImplementedException();
        }

        public void Store(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
