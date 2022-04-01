using System;
using System.Collections.Generic;
using System.Linq;

namespace MinMax
{
    class Result
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<int> arr)
        {
            int[] sum = new int[5];

            for (int i = 0; i < arr.Count(); i++)
            {
                sum[i] = arr.Sum() - arr[i];
            }

            var minSum = sum.Min();
            var maxSum = sum.Max();

            Console.WriteLine(minSum + " " + maxSum);
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
        }
    }

}
