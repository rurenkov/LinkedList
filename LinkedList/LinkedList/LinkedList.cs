using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T>
    {
        // T is the type of data stored in a particular instance of GenericList.

       

        // The following method returns the data value stored in the last node in
        // the list. If the list is empty, the default value for type T is
        // returned.
        public T GetFirstAdded()
            {
                // The value of temp is returned as the value of the method. 
                // The following declaration initializes temp to the appropriate 
                // default value for type T. The default value is returned if the 
                // list is empty.
                T temp = default(T);

                Node current = head;
                while (current != null)
                {
                    temp = current.Data;
                    current = current.Next;
                }
                return temp;
            }
        }
    }
