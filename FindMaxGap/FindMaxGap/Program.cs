using System;

namespace FindMaxGap
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(FindGap(559)); // 
        }

        public static int FindGap(int number)
        {
            int currGap = 0;
            int maxGap = 0;

            if (number == 0)
            {
                return 0;
            }
            else
            {
                foreach (char c in Convert.ToString(number, 2))
                {
                    if (c == '0')
                    {
                        currGap++;

                        // don't reinvent the wheel 
                        // maxGap = Math.Max(currGap, maxGap);
                        maxGap = MaxNumber(currGap, maxGap);
                    }
                    else
                    {
                        //reset
                        currGap = 0;
                    }
                }
                return maxGap;
            }
        }
        // try to reuse functionality
        public static int MaxNumber(int num1, int num2) => num1 > num2 ? num1 : num2;
    }
}