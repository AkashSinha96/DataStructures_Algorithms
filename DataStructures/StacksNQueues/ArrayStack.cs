using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataStructures.StacksNQueues
{
    public class ArrayStack
    {
        int top;
        int bottom;
        ArrayList intArray;
        public ArrayStack()
        {
            top = 0;
            bottom = 0;
            intArray = new ArrayList();
        }
        public void Push(int item)
        {
            //3
            //2->3
            //1->2->3
            intArray.Add(item);

        }
        public void Peek()
        {
            for (int i = intArray.Count - 1; i >= 0; i--)
            {
                Console.Write($"{intArray[i]} -> ");
            }
        }
        public void Pop()
        {
            if (intArray.Count > 0)
                intArray.RemoveAt(intArray.Count - 1);
        }
    }
}
