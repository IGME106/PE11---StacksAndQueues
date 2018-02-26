using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE11___StacksAndQueues
{
    interface IQueue
    {
        bool IsEmpty { get; }
        int Count { get; }
        void Enqueue(String s);
        String Dequeue();
        String Peek();
    }
}
