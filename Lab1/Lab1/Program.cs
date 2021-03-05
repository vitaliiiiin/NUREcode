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

            object b = "wee wee";
            listTest.AddItem(b);

            object c = 2;
            listTest.AddItem(c);
            
            listTest.PrintList();

            Console.WriteLine("\n");

            LinkedList<int> list2 = new LinkedList<int>();

            list2.AddItem(1);
            list2.AddItem(0);
            list2.AddItem(0);

            
            list2.PrintList();
            
            Console.ReadLine();
        }
    }
}