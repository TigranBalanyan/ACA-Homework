using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA_Homework.Assingmnet_4
{
    public class Matrix
    {

        public int[,] ArrayContent { get; set; }

        public int Rows { get; set; }

        public int Columns { get; set; }

        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;

            Random rnd = new Random();

            ArrayContent = new int[Rows,Columns];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    ArrayContent[i,j] = rnd.Next(10, 89);
                }
            }
        }

        public Matrix Inverse()
        {
            Matrix inverseMatrix = new Matrix(rows:Columns, columns:Rows);

            return inverseMatrix;
        }

        //public Matrix Transpose()
        //{
        //    return new Matrix();
        //}

        public bool IsOrthogonal()
        {
            return true;
        }

        static int SmallestNumber(Matrix matrix)
        {
            return 15;
        }

        static int BiggestNumber(Matrix matrix)
        {
            return 15;
        }

    }
}
