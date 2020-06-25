using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var math = new ClassLibrary1.Math();
            var ans = math.Cubed(3);
            ans = math.Modulo(3, 4);
            ans = (long)math.Inverse(3);


        }
    }
}
