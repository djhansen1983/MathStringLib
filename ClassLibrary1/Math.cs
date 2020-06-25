using System;
using System.Runtime.InteropServices;

namespace ClassLibrary1
{
    public class Math
    {
        public long Cubed(int a)
        {
            return a * a * a;
        }

        public int Modulo(int a, int b)
        {
            return a % b;
        }

        public double Inverse(double a)
        {
            return 1 / a;
        }
    }
}
