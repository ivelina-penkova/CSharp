using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Merge_sort
{
    class IterativeMergeSort
    {
        //Print array
        public static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}, ",array[i]);
            }
        }

        //Bottom-up merge sort
        public static void mergeSort(int[] array)
        {
            if (array.Length < 2)
            {
                //Array of one element is considered sorted
                return;
            }

            int step = 1;//the size of a sub-array;
            int startL, startR;//start indexes for left and right sub-arrays

            while (step < array.Length)
            {
                startL = 0;
                startR = step;
                while (startR + step <= array.Length)
                {
                    mergeArrays(array, startL, startL + step, startR, startR + step);
                    startL=startR+step;
                    startR=startL+step;
                }

                if(startR<array.Length)
                {
                    mergeArrays(array, startL, startL + step, startR, array.Length);
                }
                step*=2;
            }
        }

        //Merge to already sorted blocks
        public static void mergeArrays(int[] array, int startL, int stopL, int startR, int stopR)
        {
            //Additional arrays needed for merging
            int[] right=new int[stopR-startR+1];
            int[] left = new int[stopL - startL + 1];

            //Copy the elements to the additional arrays
            for (int i = 0, k = startR; i < (right.Length - 1); ++i, ++k)
            {
                right[i] = array[k];
            }
            for (int i = 0, k = startL; i < (left.Length - 1); ++i, ++k)
            {
                left[i] = array[k];
            }

            //Adding sentinel values
            right[right.Length - 1] = Int32.MaxValue;
            left[left.Length - 1] = Int32.MaxValue;

            // Merging the two sorted arrays into the initial one
            for (int k = startL, m = 0, n = 0; k < stopR; ++k)
            {
                if (left[m] <= right[n])
                {
                    array[k] = left[m];
                    m++;
                }
                else
                {
                    array[k] = right[n];
                    n++;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array:");
            int len = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements:");
            int[] array=new int[len];
            for (int i = 0; i < len; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            mergeSort(array);
            printArray(array);

        }
    }
}
