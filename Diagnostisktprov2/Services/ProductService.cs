﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diagnostisktprov2.Data;
using Diagnostisktprov2.Models;

namespace Diagnostisktprov2.Services
{
    public class ProductService
    { 
    private readonly ApplicationDbContext _context;

    public ProductService(ApplicationDbContext context)
    {
    _context = context;
    }
    
        public List<ProductCategory> GetAllCategories()
        {
            var allCategories = _context.ProductCategories.ToList();

            return allCategories;
        }
    }
}
