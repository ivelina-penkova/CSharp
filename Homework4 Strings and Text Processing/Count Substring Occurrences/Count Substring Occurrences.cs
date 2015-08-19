/*Write a program to find how many times a given string appears in a given text as substring.
The text is given at the first input line. The search string is given at the second input line. 
The output is an integer number. Please ignore the character casing. Overlapping between occurrences is allowed. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the text here:");
            string text = Console.ReadLine();
            Console.WriteLine("Please enter the substring here:");
            string substr = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < text.Length-substr.Length+1; i++)
            {
                if (text.Substring(i, substr.Length)==substr)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
