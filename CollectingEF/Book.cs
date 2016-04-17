using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collecting.Infrastructure
{
    /// <summary>
    /// 収集業務における書籍の永続化モデル
    /// </summary>
    [Table("book")]
    public class Book
    {
        [Key]
        public string ID { get; set; }
    }
}
