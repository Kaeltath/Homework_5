using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    internal class Bubble
    {
        private int[] sortArray;

        public Bubble()
        {
            sortArray = new int[3];
        }

        public Bubble(int[] sortArray)
        {
            this.sortArray = sortArray;
        }


        private void Sort()
        {
            bool swap = true;
            int i = 0;
            while (swap && i<sortArray.Length)
            {
            for (int j = 0; j < sortArray.Length - i - 1; j++)
                {
                    if (sortArray[j] > sortArray[j + 1])
                    {
                        Swap(j, j + 1);
                        swap = true;
                        continue;
                    }
                        swap = false;
                    
                    
                }
                i++;
           }
        }
        
        private void Swap(int a, int b)
        {
            int temp = 0;
            temp = sortArray[a];
            sortArray[a] = sortArray[b];
            sortArray[b] = temp;
        }

        public void Print()
        {
            Sort();
            foreach (int i in sortArray)
            {
                Console.Write("{0} ", i);
            }
        }

    }
}