/*Problem 5.	Reverse Number
Write a method that reverses the digits of a given floating-point number.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_Methods
{
    class Reverse_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number:");
            string number = Console.ReadLine();
            Console.WriteLine("The reversed number is: {0}",ReverseNumber(number));
        }

        static string ReverseNumber(string num)
        {
            string reversedNumber="";
            for(int i = 0; i < num.Length; i++)
            {
                reversedNumber += num[num.Length-i-1];
            }
            return reversedNumber;
        }
    }
}
