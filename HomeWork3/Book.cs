using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public  class Book
    {
        public string Title { get; set; }
        public string Autor { get; set; }

        public Book(string title,string autor) 
        {
            Title = title;
            Autor = autor;
        }
    }
}
