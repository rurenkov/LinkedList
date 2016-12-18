using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   public  class Node  <T>: LinkedList<T>
    {

        Node<T> node = new Node<T>();

        public T value;
        public Node(T value)
        {
            this.value = value;
        }



    }
}
