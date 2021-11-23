using System;

namespace TaskLibWithExpts
{
    public class TaskLib
    {
        public static double CalculateEquation(double a, double b)
        {
            if ((b - a) == 0)
            {
                throw new DivideByZeroException("B - A == 0");
            }

            return (5 * a + b * b) / (b - a);
        }

        public static void Swap(ref string a, ref string b)
        {
            if (a == null || b == null)
            {
                throw new NullReferenceException("a or b is null");
            }

            if (a != b)
            {
                string temp = a;
                a = b;
                b = temp;
            }
        }

        public static (int, int) NumberDivision(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("B  == 0");
            }

            return (a / b, a % b);
        }

        /// <summary>
        /// Calculate roots of square equation ax^2+bx+c=0
        /// </summary>
        /// <param name="a">Should not be equal to zero</param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>Roots of equation</returns>
        /// <exception cref="DivideByZeroException"/>
        /// <exception cref="ArgumentException"/>
        public static (double x1, double x2) RootsOfSquareEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException("a is equal to zero!");
            }

            double d = b * b - 4 * a * c;
            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return (x1, x2);
            }
            else if (d == 0)
            {
                double x1 = -b / (2 * a);
                return (x1, x1);
            }
            else
            {
                throw new ArgumentException("d is lower than zero!");
            }
        }

        /// <summary>
        /// Returns equation of the line passing through two different points (x1, y1) and (x2, y2)
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2">x2 is not equal x1</param>
        /// <param name="y2"></param>
        /// <returns>koefficients (A, B) of the equation Y=AX+B </returns>
        /// <exception cref="DivideByZeroException"/>
        public static (double, double) LineEquationThroughTwoPoints(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {
                throw new DivideByZeroException("x2-x1 == 0");
            }

            return ((y2 - y1) / (x2 - x1), (x2 * y1 - x1 * y2) / (x2 - x1));
        }

    }
}
