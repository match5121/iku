using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holding
{
    /// <summary>
    /// 所蔵業務における書籍モデル
    /// </summary>
    public class Book
    {
        internal HoldingID ID { get; set; }
        internal string Title { get; set; }
        internal string Author { get; set; }
    }
}
