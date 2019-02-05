using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Base Italian = Base.Italian;
            Base Regular = Base.Regular;
            Base Thick = Base.Thick;

            PizzaBase b1 = new PizzaBase(Italian, 5.00);
            PizzaBase b2 = new PizzaBase(Regular, 3.00);
            PizzaBase b3 = new PizzaBase(Thick, 3.50);

            PizzaTopping top1 = new PizzaTopping("Goat Mozzarela", 2.5);
            PizzaTopping top2 = new PizzaTopping("Deer skin", 17.00);
            PizzaTopping top3 = new PizzaTopping("Horse radish", 7);

            Pizza p1 = new Pizza(b1);

            p1.Name = "Quatro Banana";
            p1.AddTopping(top1);
            p1.AddTopping(top3);
            p1.Print();

            Pizza p2 = new Pizza(b2);
            p2.Name = "Summer Shit";
            p2.AddTopping(top2);
            p2.AddTopping(top1);
            p2.Print();

            Pizza p3 = new Pizza(b3);
            p3.Name = "Pizza for idiots";
            p3.AddTopping(top1);
            p3.Print();

            Console.ReadLine();

        }
    }
}
