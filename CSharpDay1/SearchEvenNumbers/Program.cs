using System;

namespace SearchEvenNumbers
{
    public class SearchEvenNumbers
    {
        public static void Main(string[] args)
        {
            int total = 10;
            int[] numbers = new int[total];

            for (int i = 0; i < total; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < total; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write("{0} ", numbers[i]);
                }
            }
        }
    }
}
