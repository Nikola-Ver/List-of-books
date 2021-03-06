﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Book : IEquatable<Book>
    {
        public string Isbn { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string Edition { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }
        public int Price { get; set; }

        public Book()
        {
            this.Isbn = "";
            this.Author = "";
            this.Name = "";
            this.Edition = "";
            this.Year = 0;
            this.Pages = 0;
            this.Price = 0;
        }

        public Book(string isbn, string author, string name, string edition, int year, int pages, int price)
        {
            this.Isbn = isbn;
            this.Author = author;
            this.Name = name;
            this.Edition = edition;
            this.Year = year;
            this.Pages = pages;
            this.Price = price;
        }

        public bool CompareBooks(string isbn)
        {
            return this.Isbn == isbn;
        }

        public override string ToString()
        {
            return this.Isbn + " " + this.Author + " " + this.Name +
                " " + this.Edition + " " + this.Year.ToString() + " года " + this.Pages.ToString()
                + " стр. " + this.Price.ToString() + " копеек";
        }

        public int CompareTo(Book book)
        {
            return this.Isbn.CompareTo(book.Isbn);    
        }

        public override bool Equals(object obj)
        {
            Book book = obj as Book;
            if (book == null) return false;
            return Equals(book);
        }

        public bool Equals(Book book)
        {
            return this.Isbn == book.Isbn && this.Author == book.Author && this.Name == book.Name
                   && this.Edition == book.Edition && this.Year == book.Year && this.Pages == book.Pages && this.Price == book.Price;
        }
    }
}
