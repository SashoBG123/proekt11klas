﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11a11.Model
{
    public class DBContext:DbContext
    {
        public DBContext() : base("VegetableShop")
        {

        }

        public DbSet<Vegetable> Vegetable
        {
            get;
            set;
        }

        public DbSet<VegetableType> VeganTypes
        {
            get;
            set;
        }
    }
}
