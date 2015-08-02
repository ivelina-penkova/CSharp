//Problem 5. Maximal increasing sequence
//
//   Write a program that finds the maximal increasing sequence in an array.
//
//Example:
//input 	            result
//3, 2, 3, 4, 2, 2, 4 	2, 3, 4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Maximal_increasing_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length:");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine("Enter elements of the array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxLength = 1, maxIndex = 0;
            for (int i = 1, currentLength = 1; i < arr.Length; i++)
            {
                currentLength = arr[i - 1] == arr[i]-1 ? currentLength + 1 : 1;

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxIndex = i - currentLength + 1;
                }
            }

            Console.WriteLine("The max increasing sequence is:");
            for (int i = 0; i < maxLength; i++) Console.WriteLine(arr[maxIndex + i]);
        }
    }
}
