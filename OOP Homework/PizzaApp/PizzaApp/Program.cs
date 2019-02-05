using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Blat Italian = Blat.Italian;
            Blat Regular = Blat.Regular;

            PizzaBase b1 = new PizzaBase(Regular, 7);
            PizzaTopping top1 = new PizzaTopping("Goat Mozzarela", 2.5);
            PizzaTopping top2 = new PizzaTopping("Deer skin", 17.00);
            PizzaTopping top3 = new PizzaTopping("Horse radish", 7);

            Pizza p1 = new Pizza(b1);
            p1.Name = "Quatro Useless";
            p1.AddTopping(top1);
            p1.AddTopping(top2);
            p1.Print();

            Console.ReadLine();
        }
    }

}
