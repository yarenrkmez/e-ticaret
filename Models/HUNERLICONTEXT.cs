using Hunerli.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace Hunerli.Models
{
    public class HUNERLICONTEXT:DbContext
    {
    static HUNERLICONTEXT()
        {
            Database.SetInitializer<HUNERLICONTEXT>(null);
        }
        public HUNERLICONTEXT() : base("Name=HUNERLICONTEXT")
        {

        }
        public DbSet<Products>Products { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<Satilan> Satilan { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductsTable());
            modelBuilder.Configurations.Add(new UsersTable());
            modelBuilder.Configurations.Add(new SellerTable());
            modelBuilder.Configurations.Add(new SatilanTable());
        }
    }
}