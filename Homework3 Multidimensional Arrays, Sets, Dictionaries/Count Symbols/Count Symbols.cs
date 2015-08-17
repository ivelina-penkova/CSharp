/*Problem 6.	Count Symbols
Write a program that reads some text from the console and counts the occurrences of each character in it. 
Print the results in alphabetical (lexicographical) order. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_Multidimensional_Arrays
{
    class Count_Symbols
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text here:");
            string input = Console.ReadLine();
            Dictionary<char, int> elements = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                elements[input[i]] = 0;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (elements.ContainsKey(input[i]))
                {
                    elements[input[i]] = elements[input[i]] + 1;
                }
            }

            var list = elements.Keys.ToList();
            list.Sort();

            foreach (var key in list)
            {
                Console.WriteLine("{0}: {1} time(s)", key, elements[key]);
            }

        }
    }
}
