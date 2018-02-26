using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE11___StacksAndQueues
{
    class GameQueue : IQueue
    {
        private List<String> iStack = new List<String>();

        public bool IsEmpty
        {
            get { return iStack.Any(); }
        }

        public int Count
        {
            get { return iStack.Count(); }
        }

        public void Enqueue(String s)
        {
            iStack.Add(s);
        }

        public String Dequeue()
        {
            string returnValue = returnValue = iStack[0];

            iStack.RemoveAt(0);

            return returnValue;
        }

        public String Peek()
        {
            return iStack[Count - 1];
        }
    }
}
