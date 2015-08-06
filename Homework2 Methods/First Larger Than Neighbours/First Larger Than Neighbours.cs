using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_Methods
{
    class First_Larger_Than_Neighbours
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of the array:");
            int len = int.Parse(Console.ReadLine());
            int[] array = new int[len];
            int result=-1;
            Console.WriteLine("Please enter the elements of the array:");
            FillArray(len, array);
            result = CompareWithNeighbours(array, result);
            Console.WriteLine(result);
        }

        static void FillArray(int n, int[] arr)
        {
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        static int CompareWithNeighbours(int[] arr, int res)
        {
            for (int i = 1; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    res=arr[i];
                    break;
                }
            }

            return res;
        }
    }
}
