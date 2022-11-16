using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsApp
{
    public class Methods

    {
        public static int GetStones(int totalPounds)
        {
            int stones = totalPounds / 14;
            return stones;
        }

        public static int GetPounds(int totalPounds)
        { 
            int pounds = totalPounds % 14;
            return pounds;
        }
    }
}
