using System;

namespace FizzBuzz
{
    class Result
    {
        public static void fizzBuzz(int n)
        {

            if (n % 3 == 0 && n % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (n % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (n % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(n);
            }
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.fizzBuzz(n);
        }
    }
}
