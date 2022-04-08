using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingPractise
{

    public class Program
    {
        static void Main(string[] args)
        {      
            Console.WriteLine("Enter the number count:");
            double n = Convert.ToInt32(Console.ReadLine());

            InputAndDisplay iad = new InputAndDisplay();
            List<double> numbers = iad.TakeInputAndDisplay(n);
     
            CheckPrime cp = new CheckPrime();
            cp.checkPrimeLogic(numbers);

        }
    }
}
