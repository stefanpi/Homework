    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp2._0
{
    class Book
    {
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public List<Author> Authors { get; set; }

        public Book(decimal price, string genre)
        {
            Price = price;
            Genre = genre;
            Authors = new List<Author>();

        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }

        public decimal GetPrice()
        {
            if(Genre == "Drama")
            {
                return Price = 0.10m * Price;

            }
            else if(Genre == "SF")
            {
                return Price = 0.15m * Price;
            }
            else
            {
                return Price;
            }


        }

        public void Print()
        {
            Console.WriteLine($"Genul : {Genre}  cu Pretul {Price} ");
            foreach (var author in Authors)
            {
                author.Print();
            }
             
        }


    }
}
