using System;

namespace Calculations
{
    public static class Calculator
    {
        /// <summary>
        /// Calculate the following sum 1/1 + 1/2 + 1/3 + ... + 1/n, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumOne(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/(1*2) - 1/(2*3) + 1/(3*4) + ... + (-1)^(n+1) / (n * (n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumTwo(int n)
        {
            double sum = 0;
            double rotateOne = 1.0;
            for (int i = 1; i <= n; i++)
            {
                sum += rotateOne / (i * (i + 1.0));
                rotateOne *= -1;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/1^5 + 1/2^5 + 1/3^5 + ... + 1/n^5, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumThree(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 / Math.Pow(i, 5);
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/(3 * 3) + 1/(5 * 5) + 1/(7 * 7) + ... + 1/((2 * n + 1) * (2 * n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumFour(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 / Math.Pow((2 * i) + 1, 2);
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following product
        /// (1 + 1/(1 * 1)) * (1 + 1/(2 * 2)) * (1 + 1/(3 * 3)) * ... * (1 + 1/(n * n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Product of elements.</returns>
        public static double GetProductOne(int n)
        {
            double product = 1 + (1 / (1 * 1));
            for (int i = 2; i <= n; i++)
            {
                product *= 1 + (1 / Math.Pow(i, 2));
            }

            return product;
        }

        /// <summary>
        /// Calculate the following sum
        /// -1/3 + 1/5 - 1/7 + ... + (-1)^n / (2 * n + 1), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumFive(int n)
        {
            double sum = 0;
            double rotateOne = -1.0;
            for (int i = 1; i <= n; i++)
            {
                sum += rotateOne / ((2 * i) + 1.0);
                rotateOne *= -1;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1!/1 + 2!/(1+1/2) + 3!/(1+1/2+1/3) + ... + 1*2*...* n/ (1+1/2+1/3+...+1/n), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumSix(int n)
        {
            double sum = 0;
            double divider = 0;
            double factorial = 1d;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                divider += 1.0 / i;
                sum += factorial / divider;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// Sqrt(2 + Sqrt(2 + ... + Sqrt(2))), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumSeven(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = Math.Sqrt(2 + sum);
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/sin(1) + 1/(sin(1)+sin(2)) + ...+  1/(sin(1)+sin(2)+...+sin(n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumEight(int n)
        {
            double sum = 0;
            double divider = 0;
            for (int i = 1; i <= n; i++)
            {
                divider += Math.Sin(i * Math.PI / 180);
                sum += 1 / divider;
            }

            return sum;
        }
    }
}
