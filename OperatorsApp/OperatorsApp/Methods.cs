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
            try
            {
                int stones = totalPounds / 14;
                return stones;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public static int GetPounds(int totalPounds)
        {
            try
            {
                int pounds = totalPounds % 14;
                return pounds;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
            }
        }
            
    }
}
