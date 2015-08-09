using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_Multidimensional_Arrays
{
    class Fill_the_Matrix_v2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of the matrix:");
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            bool downwards = true;
            Console.WriteLine("Enter the elements:");
            FillSpiralPattern(matrix, downwards);
            Console.WriteLine();
            PrintMatrix(matrix);
                      
            
        }

        static void FillSpiralPattern(int[,] matrix, bool direction)
        {
            for(int col = 0; col < matrix.GetLength(1); col++)
            {
                
                if (direction)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        matrix[row, col] = int.Parse(Console.ReadLine());
                    }
                }
                
                direction = !direction;
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,-3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }


    }
}
