﻿using Holding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collecting
{
    /// <summary>
    /// 収集業務における書籍のドメインモデル
    /// </summary>
    public class Book
    {
        public ISBN ID { get; set; }
        public decimal price { get; set; }
    }
}
