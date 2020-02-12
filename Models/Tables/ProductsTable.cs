using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Hunerli.Models.Tables
{
    public class ProductsTable:EntityTypeConfiguration<Products>
    {
        public ProductsTable()
        {
            this.HasKey(t => t.ProductID);
            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(40);
       

            this.Property(t => t.ProductCast)
                       .IsRequired();


            this.ToTable("Products");
            this.Property(t => t.ProductID).HasColumnName("ProductsID");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.SellerID).HasColumnName("SellerID");
            this.Property(t => t.ProductStocks).HasColumnName("ProductStocks");
            this.Property(t => t.exisT).HasColumnName("exisT");
            this.Property(t => t.ProductCast).HasColumnName("ProductCast");






        }
    }
}