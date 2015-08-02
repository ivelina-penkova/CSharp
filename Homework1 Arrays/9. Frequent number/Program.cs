//Problem 9. Frequent number

//    Write a program that finds the most frequent number in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Frequent_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array:");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            
            for(int i=0;i<length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int count = 1, temp=0, tempCount;
            int mostFrequent = arr[0];

            for(int i = 0; i < (length - 1); i++)
            {
                temp = arr[i];
                tempCount = 1;
                for(int j = i+1; j < length; j++)
                {
                    if (temp == arr[j])
                    {
                        tempCount++;
                    }
                }

                if(tempCount > count)
                {
                    mostFrequent = temp;
                    count = tempCount;
                    
                }
            }

            Console.WriteLine("{0} ({1} times)", mostFrequent,count);
        }
    }
}
