using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Hunerli.Models.Tables
{
    public class UsersTable : EntityTypeConfiguration<Users>
    {
        public UsersTable()
        {
            this.HasKey(t => t.UsersID);
            this.Property(t => t.UsersName)
                .IsRequired()
                .HasMaxLength(40);
            this.Property(t => t.UsersEmail)
       .IsRequired()
       .HasMaxLength(40);
            this.Property(t => t.UsersPp)
                       .IsRequired();
            this.Property(t => t.UsersPsw)
      .IsRequired()
      .HasMaxLength(40);
            this.Property(t => t.UsersUsername)
      .IsRequired()
      .HasMaxLength(40);




            this.ToTable("Users");
            this.Property(t => t.UsersName).HasColumnName("UsersName");
            this.Property(t => t.UsersEmail).HasColumnName("UsersEmail");
            this.Property(t => t.UsersPp).HasColumnName("UsersPp");
            this.Property(t => t.UsersPsw).HasColumnName("UsersPsw");
            this.Property(t => t.UsersUsername).HasColumnName("UsersUserName");
           
 







        }
    }
}