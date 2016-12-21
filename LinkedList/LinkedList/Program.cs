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

            // Test with a non-empty list of integers.
            LinkedList<int> linkedlist = new LinkedList<int>();
           linkedlist.Add(5);
            linkedlist.Add(4);
            linkedlist.Add(3);
            linkedlist.Print();
                        Console.WriteLine("dell***********");
            linkedlist.Delete();
            linkedlist.Print();
            Console.WriteLine("dell***********");
            linkedlist.Delete();
            linkedlist.Print();
            //       // The following line displays 5.
            //       Console.WriteLine(intVal);
            Console.ReadLine();
        }
    }
}
