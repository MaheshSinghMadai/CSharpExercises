using System;

namespace ExceptionLibrary
{
    public class demoCode
    {
        public int GrandParentMethod(int position)
        {
            int output = 0;
            Console.WriteLine("Database conn open");

            try
            {
                output = ParentMethod(position);
            }
            catch (Exception ex)
            { 
                throw;
            }
            finally
            {
                //runs even if there are exceptions
                Console.WriteLine("Database conn close");
            }     

            return output;
        }
        public int ParentMethod (int position)
        {
            return GetNumber(position);
        }
        public int GetNumber(int position)
        {
            int output = 0;
            //try
            //{
                int[] numbers = new int[] { 1, 3, 4, 6, 78 };
                output =  numbers[position];
            //}
            //catch (Exception ex)
            //{
            //    //display the exception message
            //    Console.WriteLine(ex.Message);

            //    //trace the location of the error;line number
            //    Console.WriteLine(ex.StackTrace);
            //    throw;
            //}
            return output;
        }
    }
}
