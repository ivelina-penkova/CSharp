//Problem 7. Selection sort

//    Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//    Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array:");
            int length = int.Parse(Console.ReadLine());
            int[] arr=new int[length];

            //fills the array
            for(int i=0;i<length;i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }

            int pos_min, temp;

            for(int i=0; i<length-1;i++)
            {
                pos_min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[pos_min])
                    {
                        pos_min = j;
                    }
                }

                //if pos_min is not equal to i then there's a smaller value in the array, swap is due
                if(pos_min!=i)
                {
                    temp=arr[i];
                    arr[i]=arr[pos_min];
                    arr[pos_min]=temp;
                }
            }

            for(int i=0;i<length;i++)
            {
                Console.Write("{0}, ", arr[i]);
            }
        }
    }
}
