using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWorkers
{
    internal class Worker : Human
    {
        
        public double WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }


        public Worker(string firstName, string lastName, double weekSalary, double workHourPerDay) : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHourPerDay;
        }
        public double MoneyPerHour()
        {
            return WeekSalary / (WorkHoursPerDay * 7);
        }

    }
}
