using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class Pizza
    {
        public List<PizzaTopping> PizzaTopping { get; set; }
        public PizzaBase PizzaBase { get; set; }
        public string Name { get; set; }

        

        


        public Pizza(PizzaBase pizzaBase)
        {
           
            this.PizzaBase = pizzaBase;
            this.PizzaTopping = new List<PizzaTopping>();


        }

        public void AddTopping(PizzaTopping pizzaTopping)
        {
            PizzaTopping.Add(pizzaTopping);
        }

        public double CalculateTotalCost()
        {
            double c = 0;
            c = c + this.PizzaBase.GetCost();
            foreach (var topping in PizzaTopping)
            {
                c = c + topping.Cost;

            }
            return c;

        }

        public void Print()
        {
            Console.WriteLine($"Pizza {Name}");
            this.PizzaBase.Print();
            Console.WriteLine("Toppings:");
            foreach (var topping in PizzaTopping)
            {
                topping.Print();


            }

            Console.WriteLine("Total cost: $" + this.CalculateTotalCost());



        }




    }
}
