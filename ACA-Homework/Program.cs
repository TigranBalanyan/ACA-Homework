using System;
using ACA_Homework.Assingmnet_4;

namespace ACA_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the number of Rows!");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please, enter the number of Columns!");
            int columns = Convert.ToInt32(Console.ReadLine());

            Matrix matrix = new Matrix(rows: rows, columns: columns); //creates and initalizes a matrix with random numbers

            PrintMatrix(matrix); //Prints the created Matrix

            PrintMatrix(Matrix.Inverse(matrix));  // Inverses given Matrix and prints it

            PrintMatrix(Matrix.Transpose(matrix));  // Transposes given Matrix and prints it

            Console.WriteLine(Matrix.IsOrthogonal(matrix)); //checks if orthogonal 

            Console.WriteLine(Matrix.SmallestNumber(matrix)); //Finds the smallest number of matrix

            Console.WriteLine(Matrix.LargestNumber(matrix)); //Finds the largest number
        }

        /// <summary>
        /// Prints the values of the matrix
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        static void PrintMatrix(Matrix matrix)
        {

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    Console.Write(matrix.ArrayContent[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
