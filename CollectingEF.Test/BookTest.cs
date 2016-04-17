using System;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Collecting.Infrastructure;
using Holding;
using System.Linq;

namespace CollectingEF.Test
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void PersistenceTest()
        {
            var book = new Collecting.Book() { ID = new ISBN(978, 4, 4, 865662, 7) };

            var repos = new BookRepository();
            repos.store(book);
            
            using (var db = new Context())
            {
                var expected = 1;
                var actual = db.Books.Count();

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void PersistenceTest2()
        {
            var book = new Collecting.Book() { ID = new ISBN(978, 4, 4, 865662, 7) };

            var repos = new BookRepository();
            repos.store(book);

            using (var db = new Context())
            {
                var expected = "978448656627";
                var actual = db.Books.First().ID.ToString();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
