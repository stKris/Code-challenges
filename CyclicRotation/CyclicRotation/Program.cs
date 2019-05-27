using System;

namespace CyclicRotation
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            //Console.WriteLine(arr.Length);

            int[] result = ShiftElementsToRight(arr, 4);

            foreach (var item in result)
            {
                Console.Write(item);
            }
        }

        public static int[] ShiftElementsToRight(int[] arr, int steps)
        {
            int[] tempArray = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                /** modulus formulas for circular buffer:
                    increment_address_one = (address + 1) % Length
                    decrement_address_one = (address + Length - 1) % Length
                **/

                //0+2=2%5=2
                //1+2=3%5=3
                //2+2=4%5=4
                //3+2=5%5=0
                //4+2=6%5=1

                //this index i of tempArray = this value of arr[i]
                tempArray[(i + steps) % tempArray.Length] = arr[i];
            }
            return tempArray;
        }
    }
}
