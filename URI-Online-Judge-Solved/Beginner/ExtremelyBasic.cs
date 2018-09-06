using System;

namespace Beginner
{
    public static class ExtremelyBasic
    {
        public static void Init() 
        {
            int X = 0;
            int A = 0;
            int B = 0;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            X = A + B;
            Console.WriteLine("X = " + X);
        }
    }
}