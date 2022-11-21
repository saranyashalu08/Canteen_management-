using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CanteenManagementSystem.Models
{
    public class CanteenContex:DbContext
    {
        public CanteenContex() : base("Canteen")
        {

        }
        public DbSet<Login> Login { get; set; }
        public DbSet<MenuCatalog> MenuCatalog { get; set; }
        public DbSet<MenuItems> MenuItems { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Cart> Cart { get; set; }
    }
}