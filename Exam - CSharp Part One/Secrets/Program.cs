using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secrets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your number:");
            string number = Console.ReadLine();
            double specialsum = 0;

            //computating the special sum
            for (int i = number.Length-1; i >= 0; i--)
            {
                if ((number.Length-i) % 2 == 1)
                {
                    specialsum += Char.GetNumericValue(number[i]) * Math.Pow((number.Length - i), 2.0);
                }
                else 
                {
                    specialsum += Math.Pow(Char.GetNumericValue(number[i]), 2.0) * (number.Length - i);
                }
            }
            Console.WriteLine("The special sum is {0}", specialsum);

            //computating the secret alpha sequence
            int r = Convert.ToInt32(specialsum) % 26;
            string secretAlphaSequence = "";
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string specialsumString = specialsum.ToString();
            int lenght = (int)Char.GetNumericValue(specialsumString[specialsumString.Length-1]);
            if (lenght == 0)
            {
                Console.WriteLine("{0} has no secret alpha sequence", number);
            }
            else
            {
                for (int i = 0; i < lenght; i++)
                {
                    secretAlphaSequence = secretAlphaSequence + Char.ToString(alphabet[r+i%26]);
                    
                }
                Console.WriteLine("The secret alpha sequence is {0}", secretAlphaSequence);
            }
               
            

        }
    }
}
