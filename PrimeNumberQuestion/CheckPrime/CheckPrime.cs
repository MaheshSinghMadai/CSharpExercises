using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingPractise
{
    public class CheckPrime 
    {
        public void checkPrimeLogic(List<double> numbers)
        {
            List<double> primeList = new List<double>();

            foreach (var nums in numbers)
            {
                int flag = 0; //for prime numbers

                //change flag = 1 if 1 is in the list
                if (nums == 1)
                {
                    flag = 1;
                }

                if (nums > 1)
                {
                    for (int j = 2; j < nums; j++)
                    {
                        if (nums % j == 0)
                        {
                            flag = 1;
                            break;
                        }
                    }
                }

                if (flag == 0)
                {
                    primeList.Add(nums);
                }
            }

            //display prime numbers list
            Console.WriteLine("\nPrinting the Prime List: ");
            foreach (var num in primeList)
            {
                Console.WriteLine(num);
            }

            //display sum of squares of all primeList elements
            Console.WriteLine("\nSum of Squares is: " + primeList.Sum(n => n * n));
        } 
    }

}
