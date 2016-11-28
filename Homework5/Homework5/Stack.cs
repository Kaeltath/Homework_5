using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class MyStack
    {
        private int index;
        private int[] stack ;
        
        public MyStack()
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

        public int Pop()
        {
            index--;
            return stack[index];

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

        public int Peek()
        {
            if (index == 0)
            {
                Console.WriteLine("nothing to peek");
                return 0;
            }

            return stack[index - 1];
        }
    }
}
