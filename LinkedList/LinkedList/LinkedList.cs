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


        
       public Node<T> head = null;   //init empty head of node
             


        public Node<T> CreateNode(T value)
            {

            Node<T> node = new Node<T>();
           // head = node;
           
            node.NodeValue = value;
            //node.Next = head;

            return node;
            }

         public void Add (T value)
        {
            if (head == null)
            {
                head=CreateNode(value);
                
            }
            else if (head != null && head.Next==null)
            {
                head.Next=CreateNode(value);

            }
        }  
      
        }

    }
    
    
    
