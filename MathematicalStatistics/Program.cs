using System;

namespace MathematicalStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 1000;
            float[] numbers = new float[total];
            int count = 0;

            float maxValue = float.MinValue;
            float minValue = float.MaxValue;
            float totalValues = 0.0f;

            int option;

            do
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Show");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Statistics");
                Console.WriteLine("5. Exit");

                Console.WriteLine();
                Console.Write("Enter a option (1-5): ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1: // Add

                        if (count < total)
                        {
                            numbers[count] = Convert.ToSingle(Console.ReadLine());

                            if (maxValue < numbers[count])
                            {
                                maxValue = numbers[count];
                            }

                            if (minValue > numbers[count])
                            {
                                minValue = numbers[count];
                            }

                            totalValues += numbers[count];
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("The database is full");
                        }

                        break;

                    case 2: // Show

                        if (count > 0)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                Console.Write("{0} ", numbers[i]);
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("No data available");
                        }

                        break;

                    case 3: // Search

                        if (count > 0)
                        {
                            float searchNumber = Convert.ToSingle(Console.ReadLine());

                            bool foundNumber = false;
                            for (int i = 0; i < count; i++)
                            {
                                if (numbers[i] == searchNumber)
                                {
                                    foundNumber = true;
                                }
                            }

                            if (foundNumber)
                            {
                                Console.WriteLine("Number {0} found", searchNumber);
                            }
                            else
                            {
                                Console.WriteLine("Not found");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data available");
                        }

                        break;

                    case 4: // Statistics

                        if (count > 0)
                        {
                            Console.WriteLine("Total data: {0}", count);
                            Console.WriteLine("Sum: {0}", totalValues);
                            Console.WriteLine("Average: {0}", totalValues / count);
                            Console.WriteLine("Min value: {0}", minValue);
                            Console.WriteLine("Max value: {0}", maxValue);
                        }
                        else
                        {
                            Console.WriteLine("No data available");
                        }

                        break;

                    default:
                        Console.WriteLine("Valid options (1-5)");
                        break;
                }
            }
            while (option != 5);
        }
    }
}
