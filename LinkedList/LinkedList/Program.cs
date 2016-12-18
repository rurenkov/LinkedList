using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<int> linkedlist = new LinkedList<int>();

            if (!linkedlist.Contain(0)) // Empty list
                Console.WriteLine("0 is not exist.");
            linkedlist.Print();
            linkedlist.Add(0);      // Add to empty list
            linkedlist.Add(1); linkedlist.Add(2); // attach to tail
            linkedlist.Add(2);      // duplicate add, 2 is tail.
            if (linkedlist.Contain(0))// Find existed element which is head
                Console.WriteLine("0 is exist.");
            linkedlist.Print();
            linkedlist.Delete(0);   // Delete head
            linkedlist.Delete(2);   // Delete tail
            if (!linkedlist.Delete(0)) // Delete non-exist element
                Console.WriteLine("0 is not exist.");
            linkedlist.Print();
            Console.ReadLine();


        }
    }
}
