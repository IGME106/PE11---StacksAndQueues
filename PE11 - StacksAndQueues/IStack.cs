using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE11___StacksAndQueues
{
    interface IStack
    {
        bool IsEmpty { get; }
        int Count { get; }
        void Push(String s);
        String Pop();
        String Peek();
    }
}
