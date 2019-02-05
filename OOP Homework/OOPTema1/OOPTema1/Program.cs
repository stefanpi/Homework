using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Author a1 = new Author("Bob", "bob@fu.com", "Zanzibar");
          
            Console.WriteLine("{0} , {1}, {2}", a1.name, a1.email, a1.country);

        }
    }
}
