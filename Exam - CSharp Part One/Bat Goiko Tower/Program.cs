using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bat_Goiko_Tower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n:");
            int h = int.Parse(Console.ReadLine());
            int r = (int)Math.Round(h / 2.0);
            int[] numbers = new int[r];
            for (int i = 0; i < r; i++)
            {
                numbers[i] = (i + 1) * (i + 2) / 2;
            }

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h - i - 1; j++)
                {
                    Console.Write(".");
                }

                Console.Write("/");

                if (numbers.Contains(i))
                {
                    for (int j = 0; j < 2 * i; j++)
                    {
                        Console.Write("-");
                    }
                }
                else
                {
                    for (int j = 0; j < 2 * i; j++)
                    {
                        Console.Write(".");
                    }
                }




                Console.Write("\\");

                for (int j = 0; j < h - i - 1; j++)
                {
                    Console.Write(".");

                }

                Console.WriteLine("");
            }
        }
    }
}