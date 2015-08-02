//Problem 4. Maximal sequence
//
//   Write a program that finds the maximal sequence of equal elements in an array.
//
//Example:
//input                       	result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1 	2, 2, 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Maximal_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length:");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine("Enter elements of the array:");
            for( int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxLength = 1, maxIndex = 0;
            for (int i = 1, currentLength = 1; i < arr.Length; i++)
            {
                currentLength = arr[i - 1] == arr[i] ? currentLength + 1 : 1;

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxIndex = i - currentLength + 1;
                }
            }

            Console.WriteLine("The max sequence is:");
            for (int i = 0; i < maxLength; i++) Console.WriteLine(arr[maxIndex + i]);
        }
    }
}
