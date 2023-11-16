using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    internal class Book
    {
        string title;
        string author;
        string isbn;

        public Book(string isbn, string title, string author)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
        }

        public string Title 
        { 
            get { return title; }
        }
        
    }
}
