using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class MakingTea
    {
        public async Task<string> MakeTeaAsync()
        {
            var BoilingWater = BoilWaterAsync();
            Console.WriteLine("take the cups out");
            Console.WriteLine("put tea in cups");

            var water = await BoilingWater;

            var tea = $"put {water} in cups";

            return tea;
        }

        public async Task<string> BoilWaterAsync()
        {
            Console.WriteLine("Start the kettle");
            Console.WriteLine("Waiting for the kettle");

            await Task.Delay(2000);
            Console.WriteLine("Kettle finished boiling");

            return "water";
        }
    }


    public class Program
    {
        public static async Task Main(string[] args)
        {
            MakingTea mkt = new MakingTea();
            await mkt.MakeTeaAsync();
        }
    }
}
