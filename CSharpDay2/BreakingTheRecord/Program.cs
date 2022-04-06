using BreakingTheRecord;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BreakingTheRecord
{
    class Result
    {

        /*
         * Complete the 'breakingRecords' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY scores as parameter.
         */

        /*
         * Complete the 'breakingRecords' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY scores as parameter.
         */

        public static List<int> breakingRecords(List<int> scores)
        {
            int max = 0;
            int min = 0;
            int scoreLow = scores[0];
            int scoreHigh = scores[0];

            foreach (var n in scores)
            {
                if (n < scoreLow)
                {
                    scoreLow = n;
                    min += 1;
                }
                else if (n > scoreHigh)
                {
                    scoreHigh = n;
                    max += 1;
                }
            }
            var scoreList = new List<int>();
            scoreList.Add(max);
            scoreList.Add(min);

            return scoreList;
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}

