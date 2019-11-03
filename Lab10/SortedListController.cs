using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class SortedListController<T, U>
    {
        public void FindByKey(SortedList<T, U> list, T key)
        {
            if (list.Count != 0)
            {
                if (list.ContainsKey(key))
                {
                    Console.WriteLine(list.Values[list.IndexOfKey(key)]);
                }
                else
                    Console.WriteLine("\nError key");
            }
            else
                Console.WriteLine("\nArrayList is empty");
        }

        public void deleteNElement(ref SortedList<T, U> list, int n)
        {
            int x;
            for (int i = 0; i < n; i++)
            {
                x = list.Count-1;
                list.RemoveAt(x);
            }
        }

        public void printArrayList(SortedList<T, U> list)
        {
            string str = "";
            for (int i = 0; i < list.Count; i++)
            {
                str += "  ***  \n" + list.Keys[i] + ' ' + list.Values[i] + "\n";
            }
            Console.WriteLine("\nPrint SortedList");
            Console.WriteLine("Amount of elements: " + list.Count + '\n' + str + '\n');
        }
    }
}
