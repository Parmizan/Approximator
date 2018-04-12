using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approximator
{
    class LeastSquares
    {
        private const int const_polPow = 3;
        private double[] coefficients;
        public LeastSquares(List<Point> Points)
        {
            this.coefficients = formCoefficients(Points);
        }
        private double CountElem(List<Point> Points, int i, int j)
        {
            double counter = 0;
            for (int k = 0; k < Points.Count; k++)
            {
                counter += Math.Pow(Points[k].GetX(), i + (const_polPow - j));
            }
            return counter;
        }
        private double[,] FormMatrix(List<Point> Points)
        {
            double[,] Matrix = new double[const_polPow + 1, const_polPow + 1];
            for (int i = 0; i < const_polPow + 1; i++)
            {
                for (int j = 0; j < const_polPow + 1; j++)
                {
                    Matrix[i, j] = CountElem(Points, i, j);
                }
            }
            return Matrix;
        }
        private double[] FormResArray(List<Point> Points)
        {
            double[] Array = new double[const_polPow + 1];
            for (int i = 0; i < const_polPow + 1; i++)
            {
                Array[i] = 0;
                for (int j = 0; j < Points.Count; j++)
                {
                    Array[i] += Math.Pow(Points[j].GetX(), i) * Points[j].GetY();
                }
            }
            return Array;
        }
        private List<double[,]> LU(double[,] Matrix)
        {
            double[,] L = new double[const_polPow + 1, const_polPow + 1];
            double[,] U = new double[const_polPow + 1, const_polPow + 1];
            U = Matrix;
            for (int i = 0; i < const_polPow + 1; i++)
                for (int j = i; j < const_polPow + 1; j++)
                    L[j, i] = U[j, i] / U[i, i];
            //формируем две треугольные матрицы L, U--->
            for (int k = 1; k < const_polPow + 1; k++)
            {
                for (int i = k - 1; i < const_polPow + 1; i++)
                    for (int j = i; j < const_polPow + 1; j++)
                        L[j, i] = U[j, i] / U[i, i];

                for (int i = k; i < const_polPow + 1; i++)
                    for (int j = k - 1; j < const_polPow + 1; j++)
                        U[i, j] = U[i, j] - L[i, k - 1] * U[k - 1, j];
            }
            List<double[,]> res = new List<double[,]> { L, U };
            return res;
        }
        private double[] NewResArray(List<double[,]> LU, List<Point> Points)
        {
            double[] Array = FormResArray(Points);
            for (int i = 1; i < Array.Length; i++)
            {
                double counter = 0;
                for (int k = 0; k < i; k++)
                {
                    counter += LU[0][i, k] * Array[k];
                }
                Array[i] -= counter;
            }
            return Array;
        }
        private double[] formCoefficients(List<Point> Points)
        {
            List<double[,]> lu = LU(FormMatrix(Points));
            double[] yArray = NewResArray(lu, Points);
            double[] xArray = new double[const_polPow + 1];
            xArray[const_polPow] = yArray[const_polPow] / lu[1][const_polPow, const_polPow];
            for (int i = const_polPow - 1; i > -1; i--)
            {
                double counter = 0;
                for (int k = i + 1; k < const_polPow + 1; k++)
                {
                    counter += lu[1][i, k] * xArray[k];
                }
                xArray[i] = (yArray[i] - counter) / lu[1][i, i];
            }
            return xArray;
        }
        public double getResult(double x)
        {
            double result = 0;
            for (int i = 0; i < const_polPow + 1; i++)
            {
                double temp = coefficients[i];
                for (int j = const_polPow - i; j > 0; j--)
                {
                    temp *= x;
                }
                result += temp;
            }

            return result;      //coefficients[0] * x * x * x + coefficients[1] * x * x + coefficients[2] * x + coefficients[3];
        }
        
    }
}
