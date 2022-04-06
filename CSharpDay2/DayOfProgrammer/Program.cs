using System;
using System.IO;

namespace DayOfProgrammer
{
    internal class Program
    {
        class Result
        {

            /*
             * Complete the 'dayOfProgrammer' function below.
             *
             * The function is expected to return a STRING.
             * The function accepts INTEGER year as parameter.
             */

            public static string dayOfProgrammer(int year)
            {
                String date = "";
                if (year <= 1917)
                {
                    if (year % 4 == 0)
                    {
                        date = "12.09." + year;
                    }
                    else
                    {
                        date = "13.09." + year;
                    }
                }
                else if (year == 1918)
                {
                    date = "26.09." + year;
                }
                else
                {
                    if (year % 400 == 0)
                    {
                        date = "12.09." + year;
                    }
                    else if (year % 4 == 0 && (year % 100) != 0)
                    {
                        date = "12.09." + year;
                    }
                    else
                    {
                        date = "13.09." + year;
                    }
                }
                return date;
            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
                TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                int year = Convert.ToInt32(Console.ReadLine().Trim());

                string result = Result.dayOfProgrammer(year);

                textWriter.WriteLine(result);

                textWriter.Flush();
                textWriter.Close();
            }
        }

    }
}
