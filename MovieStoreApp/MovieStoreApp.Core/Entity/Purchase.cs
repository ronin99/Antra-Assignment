﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Entity
{
    public class Purchase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PurchaseNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime PurchaseDatetTime { get; set; }
        public int MovieId { get; set; }

    }
}
