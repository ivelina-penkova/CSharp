//Problem 2. Compare arrays
//
 //   Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Compare_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the first array");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the second array");
            int n2 = int.Parse(Console.ReadLine());
            
            int[] arr1 = new int[n1];
            int[] arr2 = new int[n2];

            Console.WriteLine("Enter the numbers of the first array:");
            for (int i = 0; i < n1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the numbers of the second array:");
            for (int i = 0; i < n2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            if (n1 <= n2)
            {
                for (int i = 0; i < n1; i++)
                {
                    if (arr1[i] < arr2[i])
                    {
                        Console.WriteLine("{0}<{1}", arr1[i], arr2[i]);
                    }
                    else if (arr1[i] == arr2[i])
                    {
                        Console.WriteLine("{0}={1}", arr1[i], arr2[i]);
                    }
                    else
                    {
                        Console.WriteLine("{0}>{1}", arr1[i], arr2[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < n2; i++)
                {
                    if (arr1[i] < arr2[i])
                    {
                        Console.WriteLine("{0}<{1}", arr1[i], arr2[i]);
                    }
                    else if (arr1[i] == arr2[i])
                    {
                        Console.WriteLine("{0}={1}", arr1[i], arr2[i]);
                    }
                    else
                    {
                        Console.WriteLine("{0}>{1}", arr1[i], arr2[i]);
                    }
                }
            }

        }
    }
}
