using Microsoft.VisualStudio.TestTools.UnitTesting;
using Holding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holding.Tests
{
    [TestClass()]
    public class ISBNTests
    {
        [TestMethod()]
        public void 旧規格のISBNが生成から出力までできること()
        {
            var cut = new ISBN("4", "7981", "0837", "5");
            var expected = "ISBN4-7981-0837-5";
            var actual = cut.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 現行規格のISBNが生成から出力までできること()
        {
            var cut = new ISBN("978", "4", "04", "865662", "7");
            var expected = "ISBN978-4-04-865662-7";
            var actual = cut.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}