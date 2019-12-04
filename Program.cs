using System;
using System.Collections.Generic;

namespace AOC_Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser parser = new Parser("data.txt");

            IEnumerable<Module> modules = parser.ParseInput();

            int sum = 0;

            foreach(var m in modules)
            {
                m.CalculateFuel();
                sum += m.FuelRequired;
            }

            Console.WriteLine(sum);
        }
    }
}
