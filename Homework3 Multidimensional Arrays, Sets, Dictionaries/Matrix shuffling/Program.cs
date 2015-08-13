/*Problem 3.	Matrix shuffling
Write a program which reads a string matrix from the console and performs certain operations with its elements.
User input is provided like in the problem above – first you read the dimensions and then the data. 
Remember, you are not required to do this step first, you may add this functionality later.  
Your program should then receive commands in format: "swap x1 y1 x2 y2" where x1, x2, y1, y2 are coordinates in the matrix. In order for a command to be valid, it should start with the "swap" keyword along with four valid coordinates (no more, no less). You should swap the values at the given coordinates (cell [x1, y1] with cell [x2, y2]) and print the matrix at each step (thus you'll be able to check if the operation was performed correctly). 
If the command is not valid (doesn't contain the keyword "swap", has fewer or more coordinates entered or 
the given coordinates do not exist), print "Invalid input!" and move on to the next command. 
Your program should finish when the string "END" is entered. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_Multidimensional_Arrays
{
    class Matrix_shuffling
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the rows of the matrix:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the size of the columns of the matrix:");
            int cols = int.Parse(Console.ReadLine());
            string[,] matrix = new string[rows, cols];
            FillMatrix(matrix,rows,cols);
            Shuffle(matrix);

        }

        static void FillMatrix(string[,] m, int r, int c)
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    m[i, j] = Console.ReadLine();
                }
            }
        }

        static void Shuffle(string[,] m)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] inputArr = input.Split(' ');

                if (inputArr.Contains("swap") && inputArr.Length == 5 && (int.Parse(inputArr[1]) < m.GetLength(0)) && 
                    (int.Parse(inputArr[2]) < m.GetLength(1)) && (int.Parse(inputArr[3]) < m.GetLength(0)) && 
                    (int.Parse(inputArr[4]) < m.GetLength(1)))
                {
                    string temp = m[int.Parse(inputArr[1]), int.Parse(inputArr[2])];
                    m[int.Parse(inputArr[1]), int.Parse(inputArr[2])] = m[int.Parse(inputArr[3]), int.Parse(inputArr[4])];
                    m[int.Parse(inputArr[3]), int.Parse(inputArr[4])] = temp;
                    PrintMatrix(m);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }
        }

        static void PrintMatrix(string[,] m)
        {
            for (int row = 0;  row < m.GetLength(0);  row++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {
                    Console.Write(m[row,col]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
