using System;

namespace SimpleMath
{
    public class SimpleMath
    {
        public static float Add(int a, int b)
        {
            return a + b;
        }

        public static float Subtract(int a, int b)
        {
            return a - b;
        }

        public static double Divide(int a, int b)
        {
            return (double) a / b;
        }

        public static float Multiply(int a, int b)
        {
            return a * b;
        }

        public static float Power(int a, int b)
        {
            return (float) Math.Pow(a, b);
        }
    }
}
