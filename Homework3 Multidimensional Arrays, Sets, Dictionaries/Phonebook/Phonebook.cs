/*Problem 7.	Phonebook
Write a program that receives some info from the console about people and their phone numbers.
You are free to choose the manner in which the data is entered; each entry should have just one name and one number
(both of them strings). 
After filling this simple phonebook, upon receiving the command "search", your program should be able
to perform a search of a contact by name and print her details in format "{name} -> {number}". 
In case the contact isn't found, print "Contact {name} does not exist." 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_Multidimensional_Arrays
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            Console.WriteLine("Enter the name and the phone number devided with a dash:");
            string[] entry = new string[2];
            FillPhonebook(entry, phonebook);
            

            
        }

        static void FillPhonebook(string[] entry, Dictionary<string,string> phonebook)
        {
            string input = Console.ReadLine();
            while (input != "search")
            {
                entry = input.Split('-');
                for (int i = 0; i < 2; i++)
                {
                    phonebook[entry[0]] = entry[1];
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "EXIT")
            {
                if (phonebook.ContainsKey(input))
                {
                    Console.WriteLine("{0} --> {1}", input, phonebook[input]);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", input);
                }
                input = Console.ReadLine();
            }
        }
    }
}
