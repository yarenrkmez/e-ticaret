using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Hunerli.Models.Tables
{
    public class SellerTable : EntityTypeConfiguration<Seller>
    {
        public SellerTable()
        {
            this.HasKey(t => t.SellerID);
            this.Property(t => t.SellerName)
                .IsRequired()
                .HasMaxLength(40);
        
            this.Property(t => t.SellerAdress)
                       .IsRequired();
            this.Property(t => t.SellerEmail)
      .IsRequired()
      .HasMaxLength(40);
            this.Property(t => t.SellerUserName)
      .IsRequired()
      .HasMaxLength(40);
            this.Property(t => t.SellerPsw)
      .IsRequired();
     


            this.ToTable("Seller");
            this.Property(t => t.SellerName).HasColumnName("SellerName");
            this.Property(t => t.SellerAdress).HasColumnName("SellerAdress");
            this.Property(t => t.SellerName).HasColumnName("SellerName");
            this.Property(t => t.SellerEmail).HasColumnName("SellerEmail");
       
            this.Property(t => t.SellerUserName).HasColumnName("SellerUserName");
            this.Property(t => t.SellerPsw).HasColumnName("SellerPsw");







        }
    }
}