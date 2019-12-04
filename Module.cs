using System;
using System.Collections.Generic;
using System.Text;

namespace AOC_Day1
{
    public class Module
    {
        public int Mass;
        public int FuelRequired;

        public void CalculateFuel()
        {
            int totalFuel = 0;
            var additionalFuel = CalculateFuel(Mass);
            while(additionalFuel > 0)
            {
                totalFuel += additionalFuel;
                additionalFuel = CalculateFuel(additionalFuel);
            }

            FuelRequired = totalFuel;
        }

        private int CalculateFuel(int mass)
        {
            return (mass / 3) - 2;
        }
    }
}
