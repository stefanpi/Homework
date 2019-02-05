using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book(30, "Drama" );
            var book1 = new Book(15, "Action");
            var book2 = new Book(13, "SF");

            var author = new Author("Bob", "bob@gmail.com");
            var author1 = new Author("Jim", "jim@gmail.com");
            var author2 = new Author("Jake", "jake@gmail.com");

            book.AddAuthor(author);
            book1.AddAuthor(author2);
            book2.AddAuthor(author1);


            Library librarie = new Library("GHEORGHE ASACHI");
            librarie.AddBook(book);
            librarie.AddBook(book1);
            librarie.AddBook(book2);
            librarie.RemoveBook(book1);

            librarie.Print();
        }
    }
}
