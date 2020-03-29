﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLibraryShop.Models
{
    public class CartViewModel
    {
        public List<CartItem> CartItems { get; set; }

        public decimal GrandTotal { get; set; }

        public string Function { get; set; }
    }
}
