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
        Book find(ISBN id);

        List<Book> findAll();

        void store(Book book);

        void remove(Book book);
    }
}
