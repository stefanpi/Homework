using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3oop
{
    class Rate
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public Rate(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public string Print()
        {
            return $"{Amount} si {Currency}";
        }
    

    }
}
