/*Write a program that reads from the console a string of maximum 20 characters. 
If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the resulting string on the console.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text:");
            string input = Console.ReadLine();
            if (input.Length >= 20)
            {
                Console.WriteLine(input.Substring(0,20));
            }
            else
            {
                Console.WriteLine(input.PadRight(20,'*'));
            }
        }
    }
}
