using System;

namespace ACA_Homework.Assingmnet_4
{
    /// <summary>
    /// Matrix class which handeles matrix overloads and several functions
    /// </summary>
    public class Matrix
    {
        public int[,] ArrayContent { get; set; }

        public int Rows { get; set; }

        public int Columns { get; set; }

        /// <summary>
        /// Constructs and initalizes a matrix with random numbers from 10 to 100
        /// </summary>
        /// <param name="rows">Number of rows of matrix</param>
        /// <param name="columns">Number of columns of matrix</param>
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
                    ArrayContent[i,j] = rnd.Next(10, 100);
                }
            }
        }

        /// <summary>
        /// Transposes the matrix.
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns></returns>
        public static Matrix Transpose(Matrix matrix)
        {
            Matrix transposedMatrix = new Matrix(matrix.Columns, matrix.Rows);

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    transposedMatrix.ArrayContent[j, i] = matrix.ArrayContent[i, j]; 
                }
            }

            return transposedMatrix;
        }

        /// <summary>
        /// Distinguishing the orthogonal matrixies 
        /// </summary>
        /// <param name="matrix">Input Matrix</param>
        /// <returns></returns>
        public static bool IsOrthogonal(Matrix matrix)
        {
            if (matrix.Rows != matrix.Columns)
                return false;

            Matrix orthogonalMatrix = matrix * Transpose(matrix);

            return isIdentity(orthogonalMatrix);
        }

        /// <summary>
        /// Finding if matrix is identity matrix or not
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns></returns>
        private static bool isIdentity(Matrix matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    if (i != j && matrix.ArrayContent[i, j] != 0)
                        return false;
                    if (i == j && matrix.ArrayContent[i, j] != 1)
                        return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Inverses the given matrix
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns></returns>
        public static  Matrix Inverse(Matrix matrix)
        {
            int n = matrix.ArrayContent.Length;
            double[,] result = MatrixDuplicate(matrix);

            int[] perm;
            int toggle;
            double[][] lum = MatrixDecompose(matrix, out perm,
              out toggle);
            if (lum == null)
                throw new Exception("Unable to compute inverse");

            double[] b = new double[n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i == perm[j])
                        b[j] = 1.0;
                    else
                        b[j] = 0.0;
                }

                double[] x = HelperSolve(lum, b);

                for (int j = 0; j < n; ++j)
                    result[j][i] = x[j];
            }

            return result;
        }

        /// <summary>
        /// Finds the smallest possible number in matrix
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns></returns>
        public static int SmallestNumber(Matrix matrix)
        {
            int smallestNumber = Int32.MaxValue;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    if (matrix.ArrayContent[i, j] < smallestNumber)
                        smallestNumber = matrix.ArrayContent[i, j];
                }
            }

            return smallestNumber;
        }

        /// <summary>
        /// Finds the largest possible number in matrix
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <returns></returns>
        public static int LargestNumber(Matrix matrix)
        {
            int largestNumber = Int32.MinValue;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    if (matrix.ArrayContent[i, j] > largestNumber)
                        largestNumber = matrix.ArrayContent[i, j];
                }
            }

            return largestNumber;
        }

        /// <summary>
        /// Overloads + operator for  2 matrixes 
        /// </summary>
        /// <param name="firstMatrix">First matrix</param>
        /// <param name="secondMatrix">Second Matrix</param>
        /// <returns></returns>
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

        /// <summary>
        /// Overloads the multiply for 2 matrixes
        /// </summary>
        /// <param name="firstMatrix">First matrix</param>
        /// <param name="secondMatrix">Second Matrix</param>
        /// <returns></returns>
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

        /// <summary>
        /// Overload the * operator for a matrix and a number
        /// </summary>
        /// <param name="matrix">Input matrix</param>
        /// <param name="k">Input number</param>
        /// <returns></returns>
        public static Matrix operator* (Matrix matrix, int k)
        {
            Matrix scalarMultiplicationMatrix = new Matrix(matrix.Rows, matrix.Columns);

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)    
                {
                    scalarMultiplicationMatrix.ArrayContent[i, j] *= k;
                }
            }

            return scalarMultiplicationMatrix;
        }
    }
}
