using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            int[] sortArray;
            int choose;
            Console.WriteLine("enter 1 for bubble sorting");
            Console.WriteLine("enter 2 for insertion sorting");
            Console.WriteLine("enter 3 for stack simulation");
            Console.WriteLine("enter 4 for queue simulation");
            if (!int.TryParse(Console.ReadLine(), out choose) || choose < 1 || choose > 4)
            {
                Console.WriteLine("unsuported expression");
                Console.ReadKey();
                return;
            }
            switch (choose)
            {
                case 1:

                    sortArray = new int[] {1, 2, 6, 4, 3, 5, 6, 5, 7, 0};
                    Bubble tryBubble = new Bubble(sortArray);
                    tryBubble.Print();

                    Console.ReadLine();
                    break;
                case 2:
                    sortArray = new int[] {1, 2, 6, 4, 3, 5, 6, 1233, -3333333, 5, 7, 0};
                    Insertion tryInsertion = new Insertion(sortArray);
                    tryInsertion.Print();

                    Console.ReadLine();
                    break;
                case 3:
                    int topush;
                    int topop;
                    Stack tryStack = new Stack();
                    for (int i = 1; i < 20; i++)
                    {
                        Console.WriteLine("Please input next element to be pushed to stack");
                        if (!int.TryParse(Console.ReadLine(), out topush))
                        {
                            Console.WriteLine("unsuported expression");
                            Console.ReadKey();
                            return;
                        }
                        tryStack.Push(topush);

                        if (i%2 == 0)
                        {
                            tryStack.Pop(out topop);
                            Console.WriteLine("{0}", topop);
                        }
                        else
                        {
                            Console.WriteLine("Stack is empty");
                        }
                    }
                    /*   int topeek;
                    if (tryStack.Peek(out topeek))
                    {
                        Console.WriteLine("{0}", topeek);
                    }
                    else
                    {
                        Console.WriteLine("Stack is empty");
                    } */

                    break;
                case 4:
                    Queue tryQueue = new Queue();
                    int dequevaleue = 0;
                    for (int j = 1; j < 40; j++)
                    {
                        Console.WriteLine("plese input next element to be put in queue");
                        int value = Convert.ToInt32(Console.ReadLine());
                        tryQueue.Enqueue(value);
                        //isFull();
                        if (j%2 == 0)
                        {
                            if (tryQueue.Dequeue(out dequevaleue))
                            {
                                Console.WriteLine(dequevaleue);
                            }
                            else
                            {
                                Console.WriteLine("queue is empty");
                            }
                        }
                        //isEmpty();
                    }
                    break;
             }
        }
    }

}