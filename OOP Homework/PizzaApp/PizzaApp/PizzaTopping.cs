using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class PizzaTopping
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public PizzaTopping(string name, double cost)
        { 
            Name = name;
            Cost = cost;    
        }

        public void Print()
        {
            Console.WriteLine($"\t{Name} (${Cost})");
        }
    }
}
