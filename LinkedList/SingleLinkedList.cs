using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SingleLinkedList<T> where T: IComparable<T>
    {
        Node<T> head;
        int size;
        public SingleLinkedList()
        {
            size = 0;
            head = null;
        }
        public void AddToStart(T item)
        {
            Node<T> newNode = new Node<T>(item);
            newNode.next = head;
            head = newNode;
            size++;
        }
        public void DisplayList()
        {
            Node<T> displayNode = head;
            Console.WriteLine("");
            while (displayNode != null)
            {
                Console.Write($"{displayNode.data}->");
                displayNode = displayNode.next;
            }
        }
        public void InsertAtPosition(int pos, T val)
        {
            Node<T> tempNode = head;
            Node<T> newNode = new Node<T>(val);
            int i = 1;
            if (pos == 1)
            {
                newNode.next = head;
                head = newNode;
                size++;
            }
            if (pos == 0 || pos > (size + 1))
            {
                Console.WriteLine("Please enter valid position");
            }
            while (tempNode != null)
            {
                if (i == pos - 1)
                {
                    newNode.next = tempNode.next;
                    tempNode.next = newNode;
                    size++;
                    break;
                }
                tempNode = tempNode.next;
                i++;
            }
        }
        public void InsertAfterValue(int val, T x)
        {
            Node<T> tempNode = head;
            Node<T> newNode = new Node<T>(x);
            int i = 1;
            while (tempNode != null)
            {
                if (tempNode.data.Equals(val))
                {
                    newNode.next = tempNode.next;
                    tempNode.next = newNode;
                    size++;
                    break;
                }
                if (i == size)
                {
                    Console.WriteLine("The value to insert after is not found");
                }
                tempNode = tempNode.next;
            }

        }
        public void InsertBeforeValue(int val, T x)
        {
            Node<T> tempNode = head;
            Node<T> newNode = new Node<T>(x);
            int i = 1;
            while (tempNode.next != null)
            {
                if (tempNode.next.data.Equals(val))
                {
                    newNode.next = tempNode.next;
                    tempNode.next = newNode;
                    size++;
                    break;
                }
                if (i == size - 1)
                {
                    Console.WriteLine("The value to insert after is not found");
                }
                tempNode = tempNode.next;
            }

        }
        public void RemoveAtPosition(int x)
        {
            Node<T> tempNode = head;
            int i = 1;
            while (tempNode != null)
            {
                if (i == (x - 1))
                {
                    tempNode.next = tempNode.next.next;
                    size--;
                    break;
                }
                tempNode = tempNode.next;
                i++;
            }
        }
        public void Reverse()
        {
            //3->6->2->5->1
            //3->6->2->1->5
            Node<T> prevNode = null;
            while(head != null)
            {
                Node<T> nextNode = head.next;
                head.next = prevNode;
                prevNode = head;
                head = nextNode;
            }
            head = prevNode;
        }
    }
}
