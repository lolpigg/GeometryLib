using System;
using System.Collections.Generic;

namespace Geometry
{
    public static class Figures
    {
        public static double FindCircleArea(double Radius) => 3.14 * Math.Pow(Radius, 2);
        public static double FindTriangleArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public static bool IsTriangleRectangular(double a, double b, double c)
        {
            List<double> arr = new List<double>() { a, b, c };
            double bigger = arr[0];
            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] > bigger)
                {
                    bigger = arr[i];
                    arr.Remove(arr[i]);
                }
            }
            double result = Math.Pow(bigger, 2);
            foreach (double item in arr)
            {
                result -= Math.Pow(item, 2);
            }
            return result == 0;
        }
    }
}