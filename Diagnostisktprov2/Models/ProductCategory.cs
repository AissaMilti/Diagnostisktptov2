﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diagnostisktprov2.Models
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
