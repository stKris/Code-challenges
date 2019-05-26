using System;
using System.Collections;

namespace OddOccurrencesInArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] ar = new int[] { 9, 3, 9, 9, 3, 9, 6, 9 };

            Console.WriteLine(Solution(ar));
        }

        public static int Solution(int[] arr)
        {
            int answer = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                // XOR, makes things simple
                answer = answer ^ arr[i];
            }

            return answer;
        }
    }
}