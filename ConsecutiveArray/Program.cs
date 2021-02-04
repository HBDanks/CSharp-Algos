using System;
using System.Collections.Generic;

namespace ConsecutiveArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = new int[]{1, 2, 3, 4, 5};
            int[] test2 = new int[]{1, 2, 4, 5, 6};
            int[] test3 = new int[]{1, 2, 6, 4, 5};
            int[] test4 = new int[]{1, 3, 5};

            Console.WriteLine(ConsecutiveArray(test1));
            Console.WriteLine(ConsecutiveArray(test2));
            Console.WriteLine(ConsecutiveArray(test3));
            Console.WriteLine(ConsecutiveArray(test4));
            
        }

        private static int ConsecutiveArray(int[] arr)
        {
            int max = 1, count = 1;
            Array.Sort(arr);

            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] - arr[i-1] == 1)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if(count > max)
                {
                    max = count;
                }
            }
            
            return max;
        }
    }
}
