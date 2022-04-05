using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ElectronicShop
{
    class Solution
    {

        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            List<int> choices = new List<int>();

            for (int i = 0; i < keyboards.Count(); i++)
            {
                for (int j = 0; j < drives.Count(); j++)
                {
                    if ((keyboards[i] + drives[j]) <= b)
                    {
                        choices.Add(keyboards[i] + drives[j]);
                    }
                }
            }
            if (choices.Max() > b)
            {
                return -1;
            }
            else
            {
                return choices.Max();
            }
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
            ;

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
            ;
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int moneySpent = getMoneySpent(keyboards, drives, b);

            textWriter.WriteLine(moneySpent);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
