using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InventoryCount { get; set; }
        public decimal Price { get; set; }
        public bool IsFood { get; set; }
    }

    //public class ProductDbContext : DbContext
    //{
        //public DbSet<Product> Products { get; set; }
        //public object Product { get; internal set; }
    //}
}