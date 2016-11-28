using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class MyQueue
    {


        static int[] queue;
        static int tail, head, counter;


        public MyQueue()
        {
        queue = new int[5];
        tail = 0;
        head = 0;
        counter = 0;
        }

        public void Enqueue(int z)
        {
            counter++;
            if (counter > queue.Length)
            {
                Console.WriteLine(" item overlaped...");
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (tail < queue.Length - 1)
            {
                queue[tail] = z;
                tail++;

            }
            else
            {
                queue[tail] = z;
                tail = 0;
            }

        }
        
        public int Dequeue ()
        {
            int value;
            if (head < queue.Length - 1)
            {
                value = queue[head];
                head++;
                counter--;
                return value;
             }

            value = queue[head];
            head = 0;
            counter--;
            return value;
            
        }

        public bool isFull()
        {
            if (counter > queue.Length - 1)
            {
                return true;
            }
            
                return false;
            
        }

        public bool isEmpty()
        {
            if (counter == 0)
            {
                return true;
            }
            
            return false;
            
        }

    }
}
