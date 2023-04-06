using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOP.EFCore.ConsoleApp.Entities;

namespace OOP.EFCore.ConsoleApp.DAL.Mapping
{
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.AuthorId);
            builder.Property(a => a.Tarih).HasDefaultValueSql("GETDATE()");
            builder.Ignore(a => a.FullName); ;

            builder.HasData(
                new Author { AuthorId = 1, FirstName = "Mustafa", LastName = "Sarıgül" },

                 new Author { AuthorId = 2, FirstName = "Yusuf Eren ", LastName = "Sarıgül" }

                );

        }


    }


    public class BookAuthorMap : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.HasKey(ba => ba.BookAuthorId);

            builder.HasOne(ba => ba.Book).WithMany(b => b.BookAuthors).HasForeignKey(ba => ba.BookId);

            builder.HasOne(ba=>ba.Author).WithMany(a=>a.BookAuthors).HasForeignKey(ba=>ba.AuthorId);
        }
    }
}