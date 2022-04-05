using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ClimbingTheLeaderboard
{
    class Result
    {

        /*
         * Complete the 'climbingLeaderboard' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY ranked
         *  2. INTEGER_ARRAY player
         */

        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> result = new List<int>();

            var cleanerRank = ranked.ToHashSet().ToArray();
            int i = cleanerRank.Length - 1;

            for (int j = 0; j < player.Count; j++)
            {
                bool rankFound = false;
                while (!rankFound && i >= 0)
                {
                    if (player[j] < cleanerRank[i])
                    {
                        result.Add(i + 2);
                        rankFound = true;
                    }
                    else if (player[j] == cleanerRank[i])
                    {
                        result.Add(i + 1);
                        rankFound = true;
                    }
                    else
                    {
                        i--;
                    }
                }

                if (!rankFound)
                {
                    result.Add(1);
                }
            }

            return result;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

            int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

            List<int> result = Result.climbingLeaderboard(ranked, player);

            textWriter.WriteLine(String.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
