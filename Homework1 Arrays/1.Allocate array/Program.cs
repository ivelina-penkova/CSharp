﻿//Problem 1. Allocate array
//
//   Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//   Print the obtained array on the console.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allocate_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            for(int i = 0; i < arr.Length; i++ )
            {
                arr[i] = i * 5;
                Console.Write("{0}, ", arr[i]);
            }
            
        }
    }
}
