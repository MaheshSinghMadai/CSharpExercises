using ExceptionLibrary;
using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            demoCode demo = new demoCode();

            try
            {
                int result = demo.GrandParentMethod(3);
                Console.WriteLine("The value at given position is " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

            
        }
    }
}
