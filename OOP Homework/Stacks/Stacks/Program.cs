using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            Stack<int> myStack = new Stack<int>();

            myStack.Push(3);
            myStack.Push(8);
            myStack.Push(37);
            myStack.Push(467);
            myStack.Pop();
            myStack.Push(69);

            int topOfStack = myStack.Pop();

            

            Console.WriteLine(topOfStack);

            Console.WriteLine(myStack.Count);
            
        }
    }
}
