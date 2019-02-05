using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class PizzaBase
    {
        public Blat Name { get; set; }
        public double Cost { get; set; }

        public PizzaBase(Blat name, double cost)
        {
            Name = name;
            Cost = cost;
                
        }

        public double GetCost()
        {
            if(Name == Blat.Italian)
            {
                return 1.5 * Cost;
            }
            return Cost;
        }

        public void Print()
        {
            Console.WriteLine($"Base: {Name} (${GetCost()}");

        }
        
    }
}
