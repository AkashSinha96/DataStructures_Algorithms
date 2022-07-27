using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T> where T : IComparable<T>
    {
        public T data;
        public Node<T> next;
        public Node(T item)
        {
            this.data = item;
            next = null;
        }
    }
    
}
