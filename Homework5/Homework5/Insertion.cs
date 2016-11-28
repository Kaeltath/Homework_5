using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class InsertionSorter
    {
         private int[] sortArray;

        public InsertionSorter()
        {
            sortArray = new int[3];
        }

        public InsertionSorter(int[] sortArray)
        {
            this.sortArray = sortArray;
        }

        private void Sort()
        {
            for (int i = 1; i < sortArray.Length; i++)
            {

                int j = i;
                while (j > 0 && sortArray[j] < sortArray[j - 1])
                {
                    Swap(j, j - 1);
                    j--;
                }

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
