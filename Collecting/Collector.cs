using Holding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collecting
{
    /// <summary>
    /// 収集業務のドメインモデル
    /// </summary>
    public class Collector
    {
        private IBookRepository _store;
        private IBookRepository _library;
        private decimal _balance = 0;

        public Collector(IBookRepository store, IBookRepository library, decimal balance)
        {
            _store = store;
            _library = library;
            _balance = balance;
        }

        public Book Search(ISBN isbn=null)
        {
            return _store.Find(isbn); 
        }

        public void Buy(Book aBook)
        {
            _balance -= aBook.price;
            _library.Store(aBook);
        }


    }
}
