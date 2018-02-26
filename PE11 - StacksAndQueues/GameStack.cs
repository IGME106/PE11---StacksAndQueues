using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE11___StacksAndQueues
{
    public class GameStack : IStack
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

        public void Push(String s)
        {
            iStack.Add(s);
        }

        public String Pop()
        {
            string returnValue = returnValue = iStack[Count - 1];

            iStack.RemoveAt(Count - 1);

            return returnValue;
        }

        public String Peek()
        {
            return iStack[Count - 1];
        }
    }
}
