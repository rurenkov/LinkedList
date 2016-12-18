using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    public class Node<T> : LinkedList<T>
    {
        // Each node has a reference to the next node in the list.
        public Node Next;
        // Each node holds a value of type T.
        public T Data;
        private Node head = null;


        // The list is initially empty.


        // Add a node at the beginning of the list with t as its data value.
        public void AddNode(T t)
        {
            Node newNode = new Node();
            newNode.Next = head;
            newNode.Data = t;
            head = newNode;
        }
    }

    }

    


    }

