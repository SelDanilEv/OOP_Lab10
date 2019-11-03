using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab10
{
    class Program
    {
        private static void obsrv_Changed(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                // Следующая строка сработает если в коллекцию был добавлен элемент.
                case NotifyCollectionChangedAction.Add:
                    Figure newFigure = e.NewItems[0] as Figure;
                    Console.WriteLine("Добавлен новый объект: \n{0}\n", newFigure.ToString());
                    break;
                // Следующая строка если элемент был удален из коллекции.
                case NotifyCollectionChangedAction.Remove:
                    Figure oldFigure = e.OldItems[0] as Figure;
                    Console.WriteLine("Удален объект:\n {0}\n", oldFigure.ToString());
                    break;
                // Следующая строка сработает если элемент был перемещен.
                case NotifyCollectionChangedAction.Replace:
                    Figure replacedFigure = e.OldItems[0] as Figure;
                    Figure replacingFigure = e.NewItems[0] as Figure;
                    Console.WriteLine("Обьект \n{0}\n был заменен объектом \n{1}\n",
                        replacedFigure.ToString(), replacingFigure.ToString());
                    break;
            }
        }

        public static ObservableCollection<Figure> obsrvCollection = new ObservableCollection<Figure>
            {
                new Figure(),
                new Figure("name1","form1","color1","border1",1),
                new Figure("name NAME","form221","1color1","bord",0),
            };

        static void Main(string[] args)
        {
            del ends = StartConfiguration();
            ArrayListController contr = new ArrayListController();
            
            SortedListController<int, float> sortcontr = new SortedListController<int, float>();
            SortedListController<int,Figure> sortcontrfigure = new SortedListController<int, Figure>();

            Stack<float> stack = new Stack<float>();
            Stack<Figure> stackfigure = new Stack<Figure>();

            StackController<float> stackcontr = new StackController<float>();
            StackController<Figure> stackcontrfigure = new StackController<Figure>();

            //----------------444444444444444444444444444-----------------------------------------------------
            
            obsrvCollection.CollectionChanged += obsrv_Changed;

            obsrvCollection.Add(new Figure("name 222", "form223r", "1colfeor1", "borderring", 200));
            obsrvCollection.RemoveAt(1);
            obsrvCollection[0] = new Figure("no name", "no form", "no color", "no border", 0);

            foreach (Figure fg in obsrvCollection)
            {
                Console.WriteLine(fg.ToString());
            }
            //-------------------------------------------------------------------------------------------------

            //ArrayList firstarraylist = new ArrayList();

            //for (int q = 0; q < 5; q++)
            //    firstarraylist.Add(Math.Pow(2, q));

            //firstarraylist.Add("some string");

            //Student student = new Student(18, 2, "Danil");
            //firstarraylist.Add(student);
            //Console.WriteLine("\nWith student");
            //contr.printArrayList(firstarraylist);
            //firstarraylist.Remove(student);
            //Console.WriteLine("\nWithout student");
            //contr.printArrayList(firstarraylist);
            //firstarraylist.Add(student);

            //contr.FindByIndex(firstarraylist);

            //Console.WriteLine("\nTask 2\n");

            //SortedList<int,float> sortedList = new SortedList<int,float>();
            //for (int q = 0; q < 5; q++)
            //    sortedList.Add(q,(float)Math.Pow(q, q*2.28));
            //Console.WriteLine("Start list:");
            //sortcontr.printArrayList(sortedList);

            //Console.WriteLine("Delete 2 elements:");
            //sortcontr.deleteNElement(ref sortedList, 2);
            //sortcontr.printArrayList(sortedList);

            //sortedList.Add(321,(float)213.12312);
            //sortedList.Add(228,(float)288.8);
            //sortedList.Add(322,(float)1234.2);

            //sortcontr.printArrayList(sortedList);

            //for (int i = 0; i < sortedList.Count; i++)
            //{
            //    stack.Push(sortedList.Values[i]);
            //}
            //stackcontr.printStack(stack);



            //SortedList<int, Figure> sortedListFigure = new SortedList<int, Figure>();
            //for (int q = 0; q < 5; q++)
            //    sortedListFigure.Add(q, new Figure());
            //Console.WriteLine("Start list:");
            //sortcontrfigure.printArrayList(sortedListFigure);

            //Console.WriteLine("Delete 2 elements:");
            //sortcontrfigure.deleteNElement(ref sortedListFigure, 2);
            //sortcontrfigure.printArrayList(sortedListFigure);

            //sortedListFigure.Add(321, new Figure("name","form 1","green","solid",1));
            //sortedListFigure.Add(322, new Figure("nameWhere","form 2","blue","not",0));
            //sortedListFigure.Add(228, new Figure("nameTheName","form 228","green 228","solid",228));

            //sortcontrfigure.printArrayList(sortedListFigure);

            //for (int i = 0; i < sortedListFigure.Count; i++)
            //{
            //    stackfigure.Push(sortedListFigure.Values[i]);
            //}
            //stackcontrfigure.printStack(stackfigure);




            ends();
        }

        public static void endMes() => Console.WriteLine("\nEnd Of Program");
        public static void end() => Console.ReadKey();

        private static del StartConfiguration()
        {
            del d;
            d = endMes;
            d += end;
            return d;
        }

        delegate void del();
    }
}
