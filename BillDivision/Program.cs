using System;
using System.Collections.Generic;
using System.Linq;

namespace BillDivision
{
    class Result
    {

        /*
         * Complete the 'bonAppetit' function below.
         *
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY bill
         *  2. INTEGER k
         *  3. INTEGER b
         */

        public static void bonAppetit(List<int> bill, int k, int b)
        {
            int n = bill.Count();
            int BActual = bill.Sum();
            int Bcharged = 0;

            for (int i = 0; i < n; i++)
            {
                if (bill[i] == bill[k])
                {
                    Bcharged = BActual - bill[k];
                }
            }
            int difference = Bcharged - BActual;

            Console.WriteLine(difference);

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            Result.bonAppetit(bill, k, b);
        }
    }

}
