using System;
using DataStructures.StacksNQueues;
namespace DataStructures_Algorithms
{
    public class Program
    {

        static void Main()
        {
            ArrayStack arrayStack = new ArrayStack();
            arrayStack.Push(1);
            arrayStack.Push(2);
            arrayStack.Push(3);
            arrayStack.Peek();
            arrayStack.Pop();
            arrayStack.Peek();


        }
    }
}
