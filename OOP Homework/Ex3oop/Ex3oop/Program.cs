using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3oop
{
    class Program
    {
        static void Main(string[] args)
        {

            Rate R1 = new Rate
            {
                Amount = 1000,
                Currency = "Ron",

            };

            Room room1 = new Room
            {
                Name = "ABC",
                DailyRate = "Ron",
                Adults = 2,
                Children = 0,


            };

            Room room2 = new Room
            {
                Name = "ABCD",
                DailyRate = "Ron",
                Adults = 2,
                Children = 0,
            };

            Hotel hotel1 = new Hotel
            {
                Name = "BCA",
                City = "Iasi",
                Stars = 3,
            };

            var listacamere = new List<Room>();
            listacamere.Add(room1);
            listacamere.Add(room2);

            var str = R1.Print();
            var str2 = room1.Print();
            var str3 = hotel1.Print();

            Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.ReadLine();


        }
    }
}
