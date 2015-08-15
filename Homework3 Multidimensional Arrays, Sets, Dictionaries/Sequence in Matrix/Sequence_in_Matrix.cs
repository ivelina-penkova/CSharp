/*Problem 4.	Sequence in Matrix
We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several 
neighbour elements located on the same line, column or diagonal. Write a program that finds the longest 
sequence of equal strings in the matrix. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_Multidimensional_Arrays
{
    class Sequence_in_Matrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of the columns:");
            int cols = int.Parse(Console.ReadLine());
            string[,] matrix = new string[rows, cols];
            Console.WriteLine("Enter the elements of the matrix:");
            FillMatrix(matrix);
            string[] result = Check(matrix);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
                if (i != result.Length - 1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }
        }

        static string[] CheckForSequenceInRows(string[,] matrix)
        {
            int count=1;
            int currentCount = 1;
            string longestSequenceElement = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1])
                    {
                        currentCount++;
                        longestSequenceElement = matrix[i, j];
                    }
                    else
                    {
                        if (currentCount > count)
                        {
                            count = currentCount;
                            currentCount = 1;
                        }
                    }
                    
                }
            }

            string[] longestSequence = new string[count];
            for (int i = 0; i < count; i++)
            {
                longestSequence[i] = longestSequenceElement;
            }
            return longestSequence;
        }

        static string[] CheckForSequenceInCols(string[,] matrix)
        {
            int count = 1;
            int currentCount = 1;
            string longestSequenceElement = "";
            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == matrix[i+1, j])
                    {
                        currentCount++;
                        longestSequenceElement = matrix[i, j];
                    }
                    else
                    {
                        if (currentCount > count)
                        {
                            count = currentCount;
                            currentCount = 1;
                        }
                    }

                }
            }

            string[] longestSequence = new string[count];
            for (int i = 0; i < count; i++)
            {
                longestSequence[i] = longestSequenceElement;
            }
            return longestSequence;
        }

        static string[] CheckForSequenceInDiagonal(string[,] matrix)
        {
            int count = 1;
            int currentCount = 1;
            string longestSequenceElement = "";
            for (int i = 0; i < Math.Min(matrix.GetLength(0),matrix.GetLength(1)) - 1; i++)
            {
                if (matrix[i, i] == matrix[i + 1, i + 1])
                {
                    currentCount++;
                    longestSequenceElement = matrix[i, i];
                }
                else
                {
                    if (currentCount > count)
                    {
                        count = currentCount;
                        currentCount = 1;
                    }
                }
            }

            if (currentCount > count)
            {
                count = currentCount;
                currentCount = 1;
            }

            string[] longestSequence = new string[count];
            for (int i = 0; i < count; i++)
            {
                longestSequence[i] = longestSequenceElement;
            }
            return longestSequence;
        }

        static string[] Check(string[,] matrix)
        {
            string[] row = CheckForSequenceInRows(matrix);
            string[] col = CheckForSequenceInCols(matrix);
            string[] diagonal = CheckForSequenceInDiagonal(matrix);
            if ((Math.Max(Math.Max(row.Length, col.Length), diagonal.Length)) == row.Length)
            {
                return row;
            }
            else if ((Math.Max(Math.Max(row.Length, col.Length), diagonal.Length)) == col.Length)
            {
                return col;
            }
            else
            {
                return diagonal;
            }
            
        }

    }
}
