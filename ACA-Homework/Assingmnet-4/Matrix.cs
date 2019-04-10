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


        public Matrix Transpose()
        {
            Matrix inversedMatrix = new Matrix(Columns, Rows);

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                {
                    inversedMatrix.ArrayContent[j, i] = this.ArrayContent[i, j]; 
                }
            }

            return inversedMatrix;
        }

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

        public static Matrix operator+ (Matrix firstMatrix, Matrix secondMatrix)
        {

            if (firstMatrix.Columns != secondMatrix.Columns || firstMatrix.Rows != secondMatrix.Rows)
                return null;

            Matrix summaryMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Columns);
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Columns; j++)
                {
                    summaryMatrix.ArrayContent[i, j] = firstMatrix.ArrayContent[i, j] + secondMatrix.ArrayContent[i, j];
                }
            }

            return summaryMatrix;
        }

        public static Matrix operator* (Matrix firstMatrix, Matrix secondMatrix)
        {
            if (firstMatrix.Columns != secondMatrix.Rows)
                return null;

            Matrix multipliedMatrix = new Matrix(firstMatrix.Rows, secondMatrix.Columns);
            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < secondMatrix.Columns; j++)
                {
                    multipliedMatrix.ArrayContent[i, j] = 0;
                    for(int k = 0; k < firstMatrix.Columns; k++)
                    {
                        multipliedMatrix.ArrayContent[i, j] += firstMatrix.ArrayContent[i, k] * secondMatrix.ArrayContent[k, j];
                    }
                }
            }
            return multipliedMatrix;
        }

        public static Matrix operator* (Matrix matrix, int k)
        {
            Matrix scalarMultiplication = new Matrix(matrix.Rows, matrix.Columns);

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    scalarMultiplication.ArrayContent[i, j] *= k;
                }
            }

            return scalarMultiplication;
        }
    }
}
