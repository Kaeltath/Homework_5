using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Queue
    {


        static int[] queue;
        static int tail, head, counter;

        public Queue()
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

        public bool Dequeue(out int value)
        {
            if (counter == 0)
            {
                value = 0;
                return false;

            }
            if (head < queue.Length - 1)
            {
                value = queue[head];
                head++;
                counter--;
                return true;
            }

            value = queue[head];
            head = 0;
            counter--;
            return true;


        }

        public static void isFull()
        {
            if (counter > queue.Length - 1)
            {
                Console.WriteLine("queue is full don't add new elements untill enqeue older items");
                //Console.ReadLine();
            }
            else
            {
                Console.WriteLine("queue is not full ");
            }
        }

        public void isEmpty()
        {
            if (counter == 0)
            {
                Console.WriteLine("queue is empty");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("queue is not empty");
            }
        }

    }
}
