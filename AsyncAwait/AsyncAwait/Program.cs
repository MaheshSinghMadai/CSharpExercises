using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class MakingTea
    {
        public string MakeTea()
        {
            var water = BoilWater();
            Console.WriteLine("take the cups out");
            Console.WriteLine("put tea in cups");

            var tea = $"put {water} in cups";

            return tea;
        }
        public string BoilWater()
        {
            Console.WriteLine("Start the kettle");
            Console.WriteLine("Waiting for the kettle");
            Task.Delay(2000).GetAwaiter().GetResult();
            Console.WriteLine("Kettle finished boiling");

            return "water";

        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            MakingTea mkt = new MakingTea();
            mkt.MakeTea();
        }
    }
}
