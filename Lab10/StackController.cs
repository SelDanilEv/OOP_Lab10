using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class StackController<T>
    {
        public void printStack(Stack<T> stack)
        {
            int size = stack.Count;
            string str = "";
            if (stack.Count != 0)
            {
                while (stack.Count != 0)
                    str += "  ***  \n" + stack.Pop() + "\n";
                Console.WriteLine("Print stack");
                Console.WriteLine("Amount of elements: " + size + '\n' + str + '\n');
            }
            else
                Console.WriteLine("\nStack is empty");
        }


    }
}
