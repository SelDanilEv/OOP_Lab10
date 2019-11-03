using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class ArrayListController
    {
        public void FindByIndex(ArrayList a)
        {
            if (a.Count != 0)
            {
                Console.WriteLine("\nFind by index.Enter index: ");
                int x = -1;
                string buffers = Console.ReadLine();
                while (x == -1)
                    if (!(int.TryParse(buffers, out x) && x < a.Count && x > -1))
                    {
                        x = -1;
                        Console.WriteLine("*Wrong data*Try again*");
                        buffers = Console.ReadLine();
                    }
                    else
                        Console.WriteLine("\nThe " + x + " element is: " + a[x]);
            }
            else
                Console.WriteLine("\nArrayList is empty");
        }




        public void printArrayList(ArrayList a)
        {
            string str = "";
            foreach (object i in a)
                str += "  *  >> " + i.ToString() + " <<";
            Console.WriteLine("\nPrint ArrayList");
            Console.WriteLine("Amount of elements: " + a.Count + '\n' + str + '\n');
        }

    }
}
