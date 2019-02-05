using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3oop
{
    class Hotel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int Stars { get; set; }
        public List<Room> listacamere { get; set; }

        public string Print()
        {
            return $"Hotelul cu numele {Name} din orasul {City} are {Stars} stele. ";
        }

        public decimal pricefornumbersofrooms(Room room, int nr)
        {
            return nr * room.DailyRate.Amount;
        }

    }
}
