/*Write a program that reads a string from the console, reverses it and prints 
the result back at the console.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text here:");
            string input = Console.ReadLine();
            char[] charArr = input.ToCharArray();
            Array.Reverse(charArr);
            string output = new string(charArr);
            Console.WriteLine("The reversed text is: {0}",output);
        }
    }
}
