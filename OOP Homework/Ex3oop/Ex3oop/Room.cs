using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3oop
{
    class Room
    {
        public string Name;
        public Rate DailyRate { get; set; }
        public int  Adults { get; set; }
        public int Children { get; set; }
        public Room(string name, Rate DailyRate, int Adults, int Children)
        {

        }

        public decimal GetRateForDays(int numberOfDays)
        {
            return numberOfDays * DailyRate.Amount;
        }

        public string Print()
        {
            return $"camera cu numele {Name} are pretul de {DailyRate.Amount} {DailyRate.Currency}si poate sta {Adults} si  {Children}";
        }

    }
}
