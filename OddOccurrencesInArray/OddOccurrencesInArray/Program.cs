using System;
using System.Collections;
using System.Collections.Generic;

namespace OddOccurrencesInArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] ar = new int[] { 9, 3, 9, 3, 9, 6, 9 };
            Console.WriteLine(Solution(ar));

            int[] ar2 = new int[] { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
            Console.WriteLine(Solution2(ar2));

            int[] ar3 = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 4, 5, 5, 6, 6 };
            Console.WriteLine(Solution3(ar3));
        }

        public static int Solution(int[] arr) //xor
        {
            int answer = arr[0];

            if (arr.Length == 0)
            {
                return 0;
            }
            else
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    // XOR, makes things simple
                    answer = answer ^ arr[i];
                }
            }
            return answer;
        }

        public static int Solution2(int[] arr) //mod
        {
            int count = 0;

            if (arr.Length == 0)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int y = 0; y < arr.Length; y++)
                    {
                        if (arr[y] == arr[i])
                        {
                            count++;
                        }
                    }
                    if (count % 2 != 0)
                    {
                        return arr[i];
                    }
                }
            }
            return 0;
        }

        public static int Solution3(int[] arr) // dict/hash
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach(int i in arr)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i] = dict[i] + 1;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }

            foreach (KeyValuePair<int, int> item in dict)
            {
                if (item.Value % 2 == 1)
                {
                    return item.Key;
                }
            }
            return 0;
        }
    }
}