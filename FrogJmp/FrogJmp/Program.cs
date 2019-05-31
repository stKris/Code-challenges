using System;

namespace FrogJmp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(solution(10, 55, 10));

            Console.Read();
        }

        public static int solution(int X, int Y, int D)
        {
            if (X == Y)
            {
                return 0;
            }
            else
            {
                return (int)Math.Ceiling((decimal)(Y - X) / D);
            }
        }
    }
}
