//Problem 3. Compare char arrays
//
//   Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Compare_char_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the first array");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the second array");
            int n2 = int.Parse(Console.ReadLine());

            char[] arr1 = new char[n1];
            char[] arr2 = new char[n2];

            Console.WriteLine("Enter the characters of the first array:");
            for (int i = 0; i < n1; i++)
            {
                arr1[i] = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("Enter the characters of the second array:");
            for (int i = 0; i < n2; i++)
            {
                arr2[i] = Convert.ToChar(Console.ReadLine());
            }

            if (n1 <= n2)
            {
                for (int i = 0; i < n1; i++)
                {
                    if (arr1[i].CompareTo(arr2[i])<0)
                    {
                        Console.WriteLine("{0} precedes {1}", arr1[i], arr2[i]);
                    }
                    else if (arr1[i].CompareTo(arr2[i]) == 0)
                    {
                        Console.WriteLine("{0}={1}", arr1[i], arr2[i]);
                    }
                    else
                    {
                        Console.WriteLine("{0} follows {1}", arr1[i], arr2[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < n2; i++)
                {
                    if (arr1[i].CompareTo(arr2[i]) < 0)
                    {
                        Console.WriteLine("{0} precedes {1}", arr1[i], arr2[i]);
                    }
                    else if (arr1[i] == arr2[i])
                    {
                        Console.WriteLine("{0}={1}", arr1[i], arr2[i]);
                    }
                    else
                    {
                        Console.WriteLine("{0} follows {1}", arr1[i], arr2[i]);
                    }
                }
            }
        }
    }
}
