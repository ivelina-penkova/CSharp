using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_Multidimensional_Arrays
{
    class Fill_the_Matrix__v1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of the matrix:");
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            Console.WriteLine("Please enter the elements:");
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    matrix[col, row] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write("{0,-3}", matrix[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}
