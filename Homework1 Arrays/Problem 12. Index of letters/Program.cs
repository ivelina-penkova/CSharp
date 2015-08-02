//Problem 12. Index of letters

//    Write a program that creates an array containing all letters from the alphabet (A-Z).
//    Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Index_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)(65 + i);
            }

            Console.WriteLine("Enter a word in all caps:");
            string word = Console.ReadLine();
            for (int j = 0; j < word.Length; j++)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (word[j] == alphabet[i])
                    {
                        Console.WriteLine("{0} is at the {1} position in the alphabet",word[j],i);
                    }
                }
            }
        }
    }
}
