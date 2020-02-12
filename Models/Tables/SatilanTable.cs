using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Hunerli.Models.Tables
{
    public class SatilanTable : EntityTypeConfiguration<Satilan>
    {
        public SatilanTable()
        {
            this.HasKey(t => t.ProductID);
            this.HasKey(t => t.SellerID);
           


            this.ToTable("Satilan");
            this.Property(t => t.ProductID).HasColumnName("ProductsID");
            this.Property(t => t.SellerID).HasColumnName("SellerID");







        }
    }
}