using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book(10, "Micul Print");
            Book b2 = new Book(13, "Recreatia mare");
            Book b3 = new Book(15, "LOTR");

            Author a1 = new Author("Jimmy", "jimmy@gmail.com");
            Author a2 = new Author("Gogu", "gogu@gmail.com");
            Author a3 = new Author("George", "george@gmail.com");

            b1.AddAuthor(a1);
            b2.AddAuthor(a2);
            b3.AddAuthor(a3);

            Library librarie = new Library("UAIC");
            librarie.AddBook(b1);
            librarie.AddBook(b2);
            librarie.AddBook(b3);

            librarie.Print();




        }
    }
}
