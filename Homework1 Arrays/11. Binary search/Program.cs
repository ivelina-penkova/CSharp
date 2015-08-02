//Problem 11. Binary search

//    Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of tha array:");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine("Please enter a sorted array of integers:");
            for(int i=0;i<length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please enter the integer whose index we're looking for:");
            int number = int.Parse(Console.ReadLine());
            int searchNum=-1, mid;
            int min = 0;
            int max = length - 1;
            while (min<=max)
            {
                mid = (min + max) / 2;
                if (number > arr[mid])
                {
                    min = mid + 1;
                }
                else if(number < arr[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    searchNum = mid;
                    break;
                }

            }

            Console.WriteLine(searchNum);
        }
    }
}
