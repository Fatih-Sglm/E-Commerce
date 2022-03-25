 using EntityLayer.Concrete;
using EntityLayer.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder op)
        {
            op.UseSqlServer("server=FATIHSPC\\SQLEXPRESS;database=StoreDB; integrated security = true; ");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        
        public DbSet<Customer> Customers { get; set; }
       
        public DbSet<Personel> Personels { get; set; }

        public DbSet<VendorProduct> VendorProducts { get; set; }

        public DbSet <Brand>  Brands{ get; set; }

        public DbSet<Images> Images { get; set; }
        protected override void OnModelCreating(ModelBuilder md)
        {
            md.ApplyConfiguration(new VendorProductConfiguration());
        }
        public DbSet<Role> Roles { get; set; }
    }
}
