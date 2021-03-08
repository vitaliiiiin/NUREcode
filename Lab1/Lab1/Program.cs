using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a new list of ints
            LinkedList<int> listInts = new LinkedList<int>();
            
            //adding new nodes into the list
            Console.WriteLine("after adding new nodes into the empty list");
            listInts.AddItem(9);
            listInts.AddItem(2);
            listInts.AddItem(8);
            listInts.AddItem(7);
            listInts.AddItem(15);
            listInts.AddItem(1);
            listInts.AddItem(8);

            //printing the list and its size
            listInts.PrintList();
            Console.WriteLine("\nits size: " + listInts.ListSize());
            
            Console.WriteLine();
            
            //deleting items from the list
            listInts.DeleteItem(8);
            listInts.DeleteItem(0);
            listInts.DeleteItem(7);

            //printing the list and its size
            Console.WriteLine("after deleting items from the list");
            listInts.PrintList();
            Console.WriteLine("\nits size: " + listInts.ListSize());

            Console.WriteLine();
            
            //searching an item in the list
            Console.WriteLine("searching an item in the list");
            int itemToFind = 2;
            Console.WriteLine(itemToFind + ": " + listInts.Search(itemToFind));
            itemToFind = 8;
            Console.WriteLine(itemToFind + ": " + listInts.Search(itemToFind));
            itemToFind = 9;
            Console.WriteLine(itemToFind + ": " + listInts.Search(itemToFind));
            itemToFind = 11;
            Console.WriteLine(itemToFind + ": " + listInts.Search(itemToFind));

            Console.WriteLine();
            
            //checking if the list is empty
            Console.WriteLine("is the list empty? " + listInts.IsEmpty());
            
            Console.WriteLine("\n=================");
            
            //creating a new list of objects
            LinkedList<object> listObjects = new LinkedList<object>();

            object i = 0;
            listObjects.AddItem(i);
            i = 10;
            listObjects.AddItem(i);
            i = 5;
            listObjects.AddItem(i);
            i = 8;
            listObjects.AddItem(i);
            i = 3;
            listObjects.AddItem(i);

            //printing the list and its size
            listObjects.PrintList();
            Console.WriteLine("\nits size: " + listObjects.ListSize());
            
            //searching an item in the list
            Console.WriteLine("searching an item in the list");
            itemToFind = 10;
            Console.WriteLine(itemToFind + ": " + listObjects.Search(itemToFind));
            itemToFind = 8;
            Console.WriteLine(itemToFind + ": " + listObjects.Search(itemToFind));
            itemToFind = 0;
            Console.WriteLine(itemToFind + ": " + listObjects.Search(itemToFind));
            itemToFind = 11;
            Console.WriteLine(itemToFind + ": " + listObjects.Search(itemToFind));
            
            Console.WriteLine();
            
            //deleting items from the list
            listObjects.DeleteItem(8);
            listObjects.DeleteItem(0);
            listObjects.DeleteItem(7);

            //printing the list and its size
            Console.WriteLine("after deleting items from the list");
            listObjects.PrintList();
            Console.WriteLine("\nits size: " + listObjects.ListSize());

            Console.WriteLine();
            
            //checking if the list is empty
            Console.WriteLine("is the list empty? " + listObjects.IsEmpty());
            
            Console.ReadLine();
        }
    }
}