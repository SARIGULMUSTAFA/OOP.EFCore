﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOP.EFCore.ConsoleApp.Entities;

namespace OOP.EFCore.ConsoleApp.DAL.Mapping
{
    public class BookDetailMap : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {

            builder.HasKey(bd => bd.BookDetailId);

            builder.Property(bd => bd.ISSN).IsRequired().HasDefaultValue("0000");

            builder.Property(bd => bd.Year).HasDefaultValue("1234");


            builder.HasOne(bd => bd.Book).WithOne(b => b.BookDetail).HasForeignKey<BookDetail>(bd => bd.BookId);
        }
    }




}
