using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professor
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p1 = new Professor("Bob", "UAIC", "Biologie");
            Student s1 = new Student("Stef", "UAIC", 3);
            Student s2 = new Student("Bog", "UAIC", 2);
            Course c1 = new Course("Biologie", "Bob", 3);

            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(s1);
            listOfStudents.Add(s2);
           

            Console.WriteLine("I am {0}, i teach {1} at {2}.", p1.name, p1.specialization, p1.faculty);
            Console.WriteLine("I am {0}, i study at {1} in year {2}", s1.name, s1.faculty, s1.year);
            Console.WriteLine("The course {0} is held by {1} in year {2} and the students are  ", c1.name, c1.proffesor, c1.year);

        }
    }
}
