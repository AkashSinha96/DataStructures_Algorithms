using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.LinkedList;

namespace DataStructures.StacksNQueues
{
    public class LinkedListStack<T> where T : IComparable<T>
    {
        Node<T> top;
        Node<T> bottom;
        int length;
        public LinkedListStack()
        {
            top = null;
            bottom = null;
            length = 0;
        }
        public void Push(T item)
        {
            //3
            //2->3
            //1->2->3
            Node<T> node = new Node<T>(item);
            if (length == 0)
            {
                top = node;
                bottom = node;
                node.next = null;
            }
            else
            {
                node.next = bottom;
                bottom = node;
            }
            length++;
        }
        public void Peek()
        {
            if(length == 0)
            {
                Console.WriteLine("\nStack is empty");
            }
            Node<T> node = bottom;
            while (node != null)
            {
                Console.Write($"{node.data} -> ");
                node = node.next;
            }
        }
        public void Pop()
        {
            if(length == 1)
            {
                bottom = null;
                top = null;
            }
            else
            {
                bottom = bottom.next;
            }
            length--;
        }
    }
}
