/*
Problem 2.	Maximal Sum
Write a program that reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3 that
has maximal sum of its elements. 
On the first line, you will receive the rows N and columns M. On the next N lines you will receive each
row with its columns.
Print the elements of the 3 x 3 square as a matrix, along with their sum.
*/

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
            Console.WriteLine("Please enter the count of rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the count of columns:");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            Console.WriteLine("Enter elements:");
            FillMatrix(matrix);

            int maxSum = int.MinValue;
            int maxRow=0, maxCol=0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                             + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                             + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                        
                }
            }

            Console.WriteLine("The max sum is: {0}",maxSum);
            for (int row = maxRow; row <maxRow + 3; row++)
            {
                for (int col = maxCol; col <maxCol + 3; col++)
                {
                    Console.Write("{0,4}", matrix[row,col]);
                }
                Console.WriteLine(); 
            }
        }

        static void FillMatrix(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
