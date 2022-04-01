using PlusMinus;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlusMinus
{
    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            //count
            int positiveArray = 0;
            int negativeArray = 0;
            int zeroArray = 0;

            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i] > 0)
                {
                    //increase the positive number count by 1
                    positiveArray += 1;
                }
                else if (arr[i] < 0){

                    //increase the negative number count by 1
                    negativeArray += 1;
                }
                else
                {
                    //increase the zero number count by 1
                    zeroArray += 1;
                }
        }

        //type-casting the ratio into double for getting decimal values
        Console.WriteLine((double)positiveArray/arr.Count());
        Console.WriteLine((double)negativeArray/arr.Count());
        Console.WriteLine((double)zeroArray/arr.Count());
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}

}
