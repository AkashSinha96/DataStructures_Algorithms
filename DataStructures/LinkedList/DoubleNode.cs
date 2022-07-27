using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class DoubleNode<T> where T : IComparable<T>
    {
        public T data;
        public DoubleNode<T> next;
        public DoubleNode<T> prev;
        public DoubleNode(T item)
        {
            this.data = item;
            next = null;
            prev = null;
        }

    }
}
