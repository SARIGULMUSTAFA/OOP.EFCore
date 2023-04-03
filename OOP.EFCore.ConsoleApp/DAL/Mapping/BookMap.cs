using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOP.EFCore.ConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EFCore.ConsoleApp.DAL.Mapping
{
    public partial class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.BookId);
            builder.Property(b => b.Title).IsRequired().HasMaxLength(250);
            builder.Property(b => b.CrratedDate).HasDefaultValueSql("GETDATE()");
            builder.HasData(
                new Book { BookId = 1, Title = "Toprak Ana",CategoryId=1 },
                 new Book { BookId = 2, Title = "Gün Olur Asra Bedel", CategoryId = 1 },
                  new Book { BookId = 3, Title = "Elveda Gülsarı", CategoryId = 1 },
                   new Book { BookId = 4, Title = "Erken Gelen Turnalar", CategoryId = 1 },
                    new Book { BookId = 5, Title = "Dişi Kurdun Rüyaları", CategoryId = 1 },
                     new Book { BookId = 6, Title = "Cemile", CategoryId = 1 },
                       new Book { BookId = 7, Title = "Yıldırım Sesli Manasçı", CategoryId = 1 }

                );
            //book tablosundaki siple navigation property  category tablosundaki  public ICollection<Book> Books { get; set; } book tablosundaki CategoriyId üzerinden  ile bire çok ilişkili
            builder.HasOne(b => b.Category).WithMany(c => c.Books).HasForeignKey(b => b.CategoryId);
        }
    }
}
