using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student("Marcel", "Ion", 3),
                new Student("Podaru ", "Bogdan", 2),
                new Student("Schiopet", "Clement", 1)
            };

            var workers = new List<Worker>
            {
                new Worker("Banana", "Mihai", 2500, 40),
                new Worker("Patrunjel", "Ionut", 1700, 30),
                new Worker("Plitisit", "Stefan", 3200, 35)
            };

        }
    
    }

    public static class StudentsAndWorkersListHelper
    {
        public static void Print(List<Student> students)
        {
            foreach (var student in students)
            {
                student.Print();
            }
        }

        // Bubble sort pentru sortat studentii
        public static void Sort(List<Student> students)
        {
            Student aux;

            for (int i = 0; i < students.Count; i++)
            {
                for (int j = 0; j < students.Count; j++)
                {
                    if(students[i] < students[j])
                    {
                        aux = students[i];

                        students[i] = students[j];
                        students[j] = aux;
                    }
                }

            }
        }

        public static void Print(List<Worker> workers)
        {
            foreach (var worker in workers)
            {
                worker.Print();
            }
        }

        public static void Sort(List<Worker> workers)
        {
            

            
        }

    }
}   
