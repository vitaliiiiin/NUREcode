using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<object> listTest = new LinkedList<object>();
            
            object i = 0;
            listTest.AddItem(i);
            
            object b = 5;
            listTest.AddItem(b);
            
            object c = 2;
            listTest.AddItem(c);
            
            listTest.PrintList();
            
            Console.WriteLine("\n");

            LinkedList<int> list2 = new LinkedList<int>();

            list2.AddItem(1);
            list2.AddItem(0);
            list2.AddItem(3);
            list2.AddItem(2);
            list2.AddItem(0);

            list2.PrintList();
            Console.WriteLine();
            list2.DeleteItem(0);
            list2.PrintList();

            Console.WriteLine();
            Console.WriteLine(list2.Search(1));
            Console.WriteLine();


            LinkedList<string> list3 = new LinkedList<string>();
            
            Console.ReadLine();
        }
    }
}