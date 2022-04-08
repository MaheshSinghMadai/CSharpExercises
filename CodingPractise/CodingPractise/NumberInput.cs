using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractise
{
    public class InputAndDisplay
    {
        public List<double> TakeInputAndDisplay(double n)
        {
            List<double> numbers = new List<double>();
            numbers.Add(n);

            //List<double> primeList = new List<double>();

            //add remaining input numbers to list
            for (int i = 1; i < n; i++)
            {
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            //display numbers list
            Console.WriteLine("\nPrinting the Initial List: ");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            return numbers;
        }

    }
}
