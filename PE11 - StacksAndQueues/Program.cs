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
            GameStack myGameStack = new GameStack();

            Console.WriteLine();

            Console.WriteLine("The following spells are being put on the stack:");

            Console.WriteLine("- Shock");
            myGameStack.Push("Shock");
            Console.WriteLine("- Fork");
            myGameStack.Push("Fork");
            Console.WriteLine("- CounterSpell");
            myGameStack.Push("CounterSpell");
            Console.WriteLine("- Force of Will");
            myGameStack.Push("Force of Will");
            Console.WriteLine("- Deflection");
            myGameStack.Push("Deflection");

            Console.WriteLine();

            Console.WriteLine("Spells resolving in reverse order:");

            while (myGameStack.IsEmpty)
            {
                Console.WriteLine("- " + myGameStack.Pop());
            }

            GameQueue myGameQueue = new GameQueue();

            Console.WriteLine();

            Console.WriteLine("The following players are joining the queue:");

            Console.WriteLine("- Bob");
            myGameQueue.Enqueue("Bob");
            Console.WriteLine("- Tom");
            myGameQueue.Enqueue("Tom");
            Console.WriteLine("- Sara");
            myGameQueue.Enqueue("Sara");
            Console.WriteLine("- Jim");
            myGameQueue.Enqueue("Jim");
            Console.WriteLine("- Larry");
            myGameQueue.Enqueue("Larry");

            Console.WriteLine();

            while (myGameQueue.IsEmpty)
            {
                Console.Write("\"" + myGameQueue.Dequeue() + "\" has joined the server: ");
                Console.Write("  " + myGameQueue.Count + " player(s) left in the queue\n");
            }

            Console.ReadKey();
        }
    }

    public class GameStack : IStack
    {
        private List<String> iStack = new List<String> ();
        
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
