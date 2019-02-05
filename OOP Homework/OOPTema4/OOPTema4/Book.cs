using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTema4
{
    class Book
    {
        public string author { get; set; }
        public string title { get; set; }
        public double price { get; set; }

        public Book(string author, string title, double price)
        {
            this.author = author;
            this.title = title;
            this.price = price;


        }

        public string Print()
        {
            return $"Autorul cartii este {author}, titlul cartii este {title} iar pretul este {price}";


        }

    }
}
