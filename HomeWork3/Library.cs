using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public class Library
    {   
        private List<Book> books;
        public Library() { 
            books = new List<Book>();
        }
        public int Count => books.Count;
        public Book this[int index]
        {
            get => books[index];
            set => books[index] = value;
        }
        public Book this[string title]
        {
            get => books.Find(book => book.Title == title);
        }
        
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public bool RemoveBook(string title) 
        {
            var book = books.Find(book=> book.Title == title);
            if(book != null)
            {
                return books.Remove(book);
            }
            return false;
        
        
        }
        public bool ContainsBook(string title) 
        {
            return books.Exists(book => book.Title == title);
        }

        public static Library operator +(Library list, Book book)
        {
            list.AddBook(book);
            return list;
        }
        public static Library operator -(Library list, string name)
        {
            list.RemoveBook(name);
            return list;
        }

        public void Print()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"Книга: {books[i].Title}, автор {books[i].Autor}");
            }
        }

    }
}
