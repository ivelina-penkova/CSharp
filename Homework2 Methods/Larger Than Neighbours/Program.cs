/*Problem 3.	Larger Than Neighbours
Write a method that checks if the element at given position in a given array of integers is larger 
than its two neighbours (when such exist).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_Methods
{
    class Larger_Than_Neighbours
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of the array:");
            int len = int.Parse(Console.ReadLine());
            int[] array = new int[len];
            string[] result = new string[len];
            Console.WriteLine("Please enter the elements of the array:");
            FillArray(len, array);
            result = CompareWithNeighbours(array, result);
            PrintArray(result);

        }

        static void FillArray(int n, int[] arr)
        {
            for(int i=0;i< n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        static string[] CompareWithNeighbours(int[] arr, string[] answer)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(i==0 && arr[0] < arr[1])
                {
                    answer[0] = "false";
                }
                else if(i==0 && arr[0]>arr[i])
                {
                    answer[0] = "true";
                }
                else if(i==arr.Length-1 && arr[arr.Length - 2] < arr[arr.Length - 1])
                {
                    answer[arr.Length - 1] = "true";
                }
                else if(i == arr.Length - 1 && arr[arr.Length - 2] < arr[arr.Length - 1])
                {
                    answer[arr.Length - 1] = "false";
                }
                else if(arr[i]>arr[i-1] && arr[i] > arr[i + 1])
                {
                    answer[i] = "true";
                }
                else
                {
                    answer[i] = "false";
                }
                
            }

            return answer;
        }

        static void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            } 
        }
    }
}
