﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EFCore.ConsoleApp.Entities
{
    public class Book
    {
    
        public int BookId { get; set; }


        public int CategoryId { get; set; }

        //simple Navigation Property
        public Category Category { get; set; }

        public string Title { get; set; }

        public DateTime CreatedDate { get; set; }


        public decimal Price { get; set; }


        public BookDetail BookDetail { get; set; }

        public List<BookAuthor> BookAuthors { get; set; }
    }


}
