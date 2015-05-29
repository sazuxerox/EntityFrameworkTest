using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{
   public class BookContext : DbContext
    {
       public DbSet<Book> Books { get; set; }
       public DbSet<Category> Categories { get; set; }

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

           modelBuilder.Entity<Book>()
               .Property(p => p.PublicationName)
               .HasColumnName("Publications");
       }
    }
}
