using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE11___StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class GameStack : IStack
    {

    }

    class GameQueue : IQueue
    {

    }

    interface IStack
    {
        bool IsEmpty { get; }
        int Count { get; }
        void Push(String s);
        String Pop();
        String Peek();
    }

    interface IQueue
    {
        bool IsEmpty { get; }
        int Count { get; }
        void Enqueue(String s);
        String Dequeue();
        String Peek();
    }

}
