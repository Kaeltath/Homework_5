using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Stack
    {
        private int index;
        private int[] stack ;
        
        public Stack()
        {
            index = 0;
            stack = new int[5];
        }

       

        public void Push(int topush)
        {
            if (isFull())
            {
                Console.WriteLine("stack overflow");
                Console.ReadKey();
                Environment.Exit(0);
            }
            stack[index] = topush;
            index++;
        }

        public bool Pop(out int topop)
        {
            index--;
            if (isEmpty())
            {
                index = 0;
                topop = 0;
                return false;
            }

            topop = stack[index];
            return true;
        }

        public bool isFull()
        {
            if (index == stack.Length)
            {
                return true;
            }
            return false;

        }

        public bool isEmpty()
        {
            if (index < 0)
            {
                return true;
            }
            return false;
        }

        public bool Peek(out int topeek)
        {
            if (index < 1)
            {
                topeek = 0;
                return false;
            }

            topeek = stack[index - 1];
            return true;
        }
    }
}
