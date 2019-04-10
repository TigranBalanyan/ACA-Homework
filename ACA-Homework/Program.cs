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

            Matrix matrix = new Matrix(rows: rows, columns: columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix.ArrayContent[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
