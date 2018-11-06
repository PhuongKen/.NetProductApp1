﻿using ProjectApps1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectApps1.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}