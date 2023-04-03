using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using OOP.EFCore.ConsoleApp.DAL.Mapping;
using OOP.EFCore.ConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EFCore.ConsoleApp.DAL
{
    public class BookappDbContext:DbContext
    {


        public DbSet<Book> Books { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=TOKAT153;Initial Catalog=BookAppDb;Integrated Security = SSPI; MultipleActiveResultSets = True");

            optionsBuilder.UseSqlServer("Server=TOKAT153;Database=BookAppDb;Integrated Security = SSPI; MultipleActiveResultSets = True");

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookMap());
        }

    }
}

//Server = TOKAT153; Database = ASistem1; Integrated Security = SSPI; MultipleActiveResultSets = True