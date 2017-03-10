using System;
using System.Text;

namespace MatrixProblem
{
    public class Matrix<T> 
    {
        private int row;
        private int col;

        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.MatrixArr = new T[this.Row, this.Col];
        }

        public int Row
        {
            get
            {
                return this.row;
            }
            set
            {
                this.row = value;

            }
        }

        public int Col
        {
            get
            {
                return this.col;
            }
            set
            {
                this.col = value;
            }
        }

        public T[,] MatrixArr { get; private set; }

        /// <summary>
        /// Implement an indexer
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public T this[int row, int col]
        {
            get
            {
                return this.MatrixArr[row, col];

            }
            set
            {
                this.MatrixArr[row, col] = value;
            }
        }

        /// <summary>
        /// Implement the operator +
        /// </summary>
        /// <param name="matrixOne"></param>
        /// <param name="matrixTwo"></param>
        /// <returns></returns>
        public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.Row != matrixTwo.Row || matrixOne.Col != matrixTwo.Col)
            {
                throw new ArgumentOutOfRangeException("Matrix must be equal size!");
            }

            var matrix = new Matrix<T>(matrixOne.Row, matrixOne.Col);

            for (int i = 0; i < matrixOne.Row; i++)
            {
                for (int j = 0; j < matrixOne.Col; j++)
                {
                    matrix[i, j] = (dynamic)matrixOne[i, j] + matrixTwo[i, j];
                }
            }

            return matrix;
        }

        /// <summary>
        /// Implement the operator -
        /// </summary>
        /// <param name="matrixOne"></param>
        /// <param name="matrixTwo"></param>
        /// <returns></returns>
        public static Matrix<T> operator -(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.Row != matrixTwo.Row || matrixOne.Col != matrixTwo.Col)
            {
                throw new ArgumentOutOfRangeException("Matrix must be equal size!");
            }

            var matrix = new Matrix<T>(matrixOne.Row, matrixOne.Col);

            for (int i = 0; i < matrixOne.Row; i++)
            {
                for (int j = 0; j < matrixOne.Col; j++)
                {
                    matrix[i, j] = Math.Abs((dynamic)matrixOne[i, j] - matrixTwo[i, j]);
                }
            }

            return matrix;
        }

        /// <summary>
        /// Implement the operator *
        /// </summary>
        /// <param name="matrixOne"></param>
        /// <param name="matrixTwo"></param>
        /// <returns></returns>
        public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.Row != matrixTwo.Row || matrixOne.Col != matrixTwo.Col)
            {
                throw new ArgumentOutOfRangeException("Matrix must be equal size!");
            }

            var matrix = new Matrix<T>(matrixOne.Row, matrixOne.Col);

            for (int i = 0; i < matrixOne.Row; i++)
            {
                for (int j = 0; j < matrixOne.Col; j++)
                {
                    matrix[i, j] = (dynamic) matrixOne[i, j]*matrixTwo[i, j];
                }
            }

            return matrix;
        }

        /// <summary>
        /// Implement the true operator
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static bool operator true(Matrix<T> matrix)
        {
            bool isTrue = false;
            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    isTrue = (dynamic) matrix[i, j] != 0;
                }
            }

            return isTrue;
        }

        /// <summary>
        /// Implement the false operator
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static bool operator false(Matrix<T> matrix)
        {
            bool isTrue = false;
            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    isTrue = (dynamic)matrix[i, j] != 0;
                }
            }

            return isTrue;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Col; j++)
                {
                    result.Append(MatrixArr[i, j] + " ");
                }

                result.AppendLine();
            }

            return result.ToString();
        }
    }
}