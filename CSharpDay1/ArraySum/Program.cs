﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRankSolutions
{
    class Result
    {

        /*
         * Complete the 'simpleArraySum' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY ar as parameter.
         */

        public static int simpleArraySum(List<int> ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Count(); i++)
            {
                sum += ar[i];
            }
            return sum;
        }
    }
    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = Result.simpleArraySum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
