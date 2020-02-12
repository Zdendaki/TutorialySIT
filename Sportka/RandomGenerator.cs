using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportka
{
    class RandomGenerator
    {
        Random Rand;
        
        public RandomGenerator()
        {
            Rand = new Random();
        }

        public string GenerateField()
        {
            string output = string.Empty;

            for (int i = 0; i < 6; i++)
            {
                output += " " + Rand.Next(1, 49).ToString("D2");
            }

            return output;
        }

        public int GenerateChance()
        {
            return Rand.Next(100000, 999999);
        }
    }
}
