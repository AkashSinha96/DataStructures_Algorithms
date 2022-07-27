using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class DoubleLinkedList<T> where T : IComparable<T>
    {
        public DoubleNode<T> head;
        public DoubleNode<T> tail;
        public int size;
        public DoubleLinkedList()
        {
            head = null;
            tail = null;
        }
        public void AddToStart(T item)
        {
            DoubleNode<T> node = new DoubleNode<T>(item);
            //1
            //2->1
            //3->2->1
            node.next = head;
            node.prev = null;
            if (head != null)
                head.prev = node;
            head = node;
            if (size == 0)
            {
                tail = node;
            }
            size++;

        }
        public void DisplayList()
        {
            DoubleNode<T> node = tail;
            while (node != null)
            {
                Console.Write($"{node.data} -> ");
                node = node.prev;
            }
        }

    }
}
