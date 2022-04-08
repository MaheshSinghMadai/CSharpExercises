using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingPractise
{

    public class Program
    {
        static void Main(string[] args)
        {      
            List<double> primeList = new List<double>();

            Console.WriteLine("Enter the number count:");
            double n = Convert.ToInt32(Console.ReadLine());

            InputAndDisplay iad = new InputAndDisplay();
            List<double> numss = iad.TakeInputAndDisplay(n);
     
            CheckPrime cp = new CheckPrime();
            cp.checkPrimeLogic(numss);

        }
    }
}
