using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp1._2
{
    class PizzaTopping
    {
        //        PizzaTopping
        //Name(Can be: Cheese, Meat, Vegetable)
        //Cost
        //Print();

        public string Name { get; set; }
        public double Cost { get; set; }

        public PizzaTopping(string name, double cost)
        {
            Name = name;
            Cost = cost;
                
        }

        public void Print()
        {
            Console.WriteLine($"Name {Name} Cost {Cost}");
        }
    }

}
