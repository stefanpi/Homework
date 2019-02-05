using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTema4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> listecarti = new List<Book>();
            
            var book1 = new Book("Mark Manson", "THE SUBTLE ART OF NOT GIVING A FUCK", 15.00);
            var book2 = new Book( "Paulo Coelho", "THE ALCHIMIST", 10.00);
            var book3 = new Book("Gabriel Garcia Marzquez", "OF LOVE AND OTHER DEMONS", 8.00);
            var book4 = new Book("Emily Bronte", "WHITHERING HEIGHTS", 13.00);
            var book5 = new Book("J.R.R Tolkein", "THE FALL OF GONDOLIN", 11.00);

            listecarti.Add(book1);
            listecarti.Add(book2);
            listecarti.Add(book3);
            listecarti.Add(book4);
            listecarti.Add(book5);

            int nrcarte = 0;

            foreach (var element in listecarti)
            {
                if(nrcarte == 0 || nrcarte == 1)
                {
                    element.price = element.price * 1.5;

                    Console.WriteLine(element.Print());

                }
                else
                {
                    Console.WriteLine(element.Print());
                }
                nrcarte++;

            }

            Console.ReadKey();
            
        }
    }
}
