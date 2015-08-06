/*Problem 2.	Last Digit of Number
Write a method that returns the last digit of a given integer as an English word.
Test the method with different input values. Ensure you name the method properly.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_Methods
{
    class Last_Digit_of_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number:");
            string number = Console.ReadLine();
            Console.WriteLine(GetWordFromNumber(number));
        }

        static string GetWordFromNumber(string num)
        {
            char lastDigit = num[num.Length - 1];
            string word = "";
            switch (lastDigit)
            {
                case '0': word = "zero";
                    break;
                case '1':
                    word = "one";
                    break;
                case '2':
                    word = "two";
                    break;
                case '3':
                    word = "three";
                    break;
                case '4':
                    word = "four";
                    break;
                case '5':
                    word = "five";
                    break;
                case '6':
                    word = "six";
                    break;
                case '7':
                    word = "seven";
                    break;
                case '8':
                    word = "eight";
                    break;
                case '9':
                    word = "nine";
                    break;
                default: Console.WriteLine("Non-valid input!");
                    break;
            }
            return word;
        }
    }
}
