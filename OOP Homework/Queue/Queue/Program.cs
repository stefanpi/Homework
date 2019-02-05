using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQ = new Queue();

            myQ.Enqueue("String 1");
            myQ.Enqueue("String 2");
            myQ.Enqueue("String 3");
            myQ.Enqueue("String 4");
            myQ.Enqueue("String 5");

            Console.WriteLine("There are {0} objects in the Queue", myQ.Count);

            while(myQ.Count > 0)
            {
                string str = (string)myQ.Dequeue();
                Console.WriteLine("Dequeueing object {0}", str);
            }


        }
    }
}
