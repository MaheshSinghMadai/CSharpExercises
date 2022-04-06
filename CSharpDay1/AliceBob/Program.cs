using AliceBob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AliceBob
{
    class Result
    {

        /*
         * Complete the 'compareTriplets' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int rewardAlice = 0;
            int rewardBob = 0;

            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                {
                    rewardAlice += 1;
                }
                else if (b[i] > a[i])
                {
                    rewardBob += 1;
                }
                else
                {

                }
            }
            var comparisonPoint = new List<int>() { rewardAlice, rewardBob };

            return comparisonPoint; ;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
}
