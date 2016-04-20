using Holding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collecting
{
    public interface IBookRepository
    {
        Book Find(ISBN id);

        List<Book> FindAll();

        void Store(Book book);

        void Remove(Book book);
    }
}
