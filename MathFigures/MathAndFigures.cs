using System;

namespace MathFigures
{
    public class MathAndFigures
    {
        public static double CircleArea(double radius)
        {
            if (radius <= 0)
            {
                throw new Exception("Кружок не может существовать в таких условиях");
            }

            return radius * radius * Math.PI;
        }

        public static double TriangleArea(double a, double b, double c)
        {
            IsTriangleExist(a, b, c);

            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static bool IsRightTriangle(double a, double b, double c)
        {
            IsTriangleExist(a, b, c);

            var aa = a * a;
            var bb = b * b;
            var cc = c * c;

            if (
               aa == bb + cc ||
               bb == aa + cc ||
               cc == aa + bb)
            {
                return true;
            }
            return false;
        }

        private static void IsTriangleExist(double a, double b, double c)
        {
            var result = (a > 0 && b > 0 && c > 0 && a < b + c && b < a + c && c < b + a);

            if (!result)
            {
                throw new Exception("Треугольник не может существовать в таких условиях");
            }
        }
    }
}
