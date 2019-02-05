using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWorkers
{
    class Student : Human
    {

        public int Grade { get; set; }

        public Student(string firstName, string lastName, int grade) : base(firstName,lastName)
        {
            Grade = grade;
        }

        public void Print()
        {
            Console.WriteLine($"Student: {FirstName} {LastName}, Grade: {Grade} ");
        }

        public static bool operator <(Student s1, Student s2)
        {
            if(s1.Grade < s2.Grade)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Student s1, Student s2)
        {
            if(s1.Grade > s2.Grade)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}   
