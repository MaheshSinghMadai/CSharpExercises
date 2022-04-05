using System;
public class ArrayReverseOrden
{
    public static void Main(string[] args)
    {
        int total = 5;
        int[] numbers = new int[total];

        for (int i = 0; i < total; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Reverse(numbers);

        for (int i = 0; i < total; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }
    }
}
