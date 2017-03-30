using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmasTOPMigle.Helpers
{
    public class RandomGen
    {
        public static int GenerateInt(int first, int second)
        {
            Random random = new Random();
            int numb = random.Next(first, (second+1)); // if (0, 100), +1 to include 100
            return numb;
        }
    }
}
