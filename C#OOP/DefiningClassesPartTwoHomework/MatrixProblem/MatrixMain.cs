using System;

namespace MatrixProblem
{
    public class MatrixMain
    {
        static void Main()
        {
            Matrix<int> matrixOne = new Matrix<int>(2, 2);
            matrixOne[0, 0] = 5;
            matrixOne[0, 1] = 3;
            matrixOne[1, 0] = 7;
            matrixOne[1, 1] = 8;

            Matrix<int> matrixTwo = new Matrix<int>(2, 2);
            matrixTwo[0, 0] = 4;
            matrixTwo[0, 1] = 1;
            matrixTwo[1, 0] = 2;
            matrixTwo[1, 1] = 3;

            var matrixResult = matrixOne * matrixTwo;
            var matrixResultOne = matrixOne + matrixTwo;
            var matrixResultTwo = matrixOne - matrixTwo;

            Console.WriteLine("First matrix");
            Console.WriteLine(matrixOne.ToString());

            Console.WriteLine("Second matrix");
            Console.WriteLine(matrixTwo.ToString());

            Console.WriteLine("Matrix with *");
            Console.WriteLine(matrixResult.ToString());

            Console.WriteLine("Matrix with +");
            Console.WriteLine(matrixResultOne.ToString());

            Console.WriteLine("Matrix with -");
            Console.WriteLine(matrixResultTwo.ToString());
        }
    }
}