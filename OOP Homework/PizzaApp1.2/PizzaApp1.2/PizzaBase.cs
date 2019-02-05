using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp1._2
{
    class PizzaBase
    {
        //        PizzaBase
        //Name(Can be: Regular, Thick, Italian)
        //Cost
        //Print();

        public Base  Name { get; set; }
        public double Cost { get; set; }

        public PizzaBase(Base name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public double GetCost()
        {
            if(Name == Base.Italian)
            {
                return 1.5 * Cost;
            }
            return Cost;
        }


        public void Print()
        {
            Console.WriteLine($"Name {Name} , Cost : {Cost}");
        }


            
    }
}
