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
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.BookId);
            builder.Property(b => b.Title).IsRequired().HasMaxLength(250);
            builder.Property(b=>b.CrratedDate).HasDefaultValue(DateTime.Now);
            builder.HasData(
                new Book { BookId = 1, Title = "Toprak Ana" },
                 new Book { BookId = 2, Title = "Gün Olur Asra Bedel" },
                  new Book { BookId = 3, Title = "Elveda Gülsarı" },
                   new Book { BookId = 4, Title = "Erken Gelen Turnalar" },
                    new Book { BookId = 5, Title = "Dişi Kurdun Rüyaları" },
                     new Book { BookId = 6, Title = "Cemile" },
                       new Book { BookId = 7, Title = "Yıldırım Sesli Manasçı" }

                );
        }
    }
}
