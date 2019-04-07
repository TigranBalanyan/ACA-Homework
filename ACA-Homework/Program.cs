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
        }
    }
}
