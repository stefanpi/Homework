using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp2._0
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }

        public Library(string name)
        {
            Name = name;
            Books = new List<Book>();
        }

        public void Print()
        {
            Console.WriteLine($"Biblioteca {Name} cu cartile {Books.Count}");
            foreach (var book in Books)
            {
                book.Print();
            }
        }
    }
}    
