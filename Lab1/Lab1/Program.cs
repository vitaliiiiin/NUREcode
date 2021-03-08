using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // LinkedList<object> listTest = new LinkedList<object>();
            //
            // object i = 0;
            // listTest.AddItem(i);
            //
            // object b = 5;
            // listTest.AddItem(b);
            //
            // object c = 2;
            // listTest.AddItem(c);
            //
            // listTest.PrintList();
            //
            // Console.WriteLine("\n");
            //
            // LinkedList<int> list2 = new LinkedList<int>();
            //
            // list2.AddItem(1);
            // list2.AddItem(0);
            // list2.AddItem(3);
            // list2.AddItem(2);
            // list2.AddItem(0);
            //
            // list2.PrintList();
            // Console.WriteLine();
            // list2.DeleteItem(0);
            // list2.PrintList();
            //
            // Console.WriteLine();
            // Console.WriteLine(list2.Search(1));
            // Console.WriteLine();
            //
            //
            // LinkedList<string> list3 = new LinkedList<string>();
            //
            // list3.AddItem("z");
            // list3.AddItem("b");
            // list3.AddItem("k");
            // list3.AddItem("a");
            // list3.AddItem("a");
            //
            // list3.PrintList();

            //creating a new list
            LinkedList<int> listInts = new LinkedList<int>();
            
            //adding new nodes into the list
            listInts.AddItem(9);
            listInts.AddItem(2);
            listInts.AddItem(8);
            listInts.AddItem(7);
            listInts.AddItem(15);
            listInts.AddItem(1);
            listInts.AddItem(8);

            //printing the list
            listInts.PrintList();
            
            //deleting items from the list
            listInts.DeleteItem(8);
            listInts.DeleteItem(0);
            listInts.DeleteItem(7);

            Console.WriteLine("\n");
            
            //printing the list
            listInts.PrintList();

            Console.WriteLine("\n");
            
            

            Console.ReadLine();
        }
    }
}