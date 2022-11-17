using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsApp
{
    internal class LoopTypes
    {
        internal static int HighestDoWhileLoop(List<int> nums)
        {
            int highest = int.MinValue;
            int i = 0;
            do
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
                i++;
            } while (i < nums.Count);
            return highest;
        }

        internal static int HighestForEachLoop(List<int> nums)
        {
            int highest = int.MinValue;
            foreach (var x in nums)
            {
                if (highest < x) 
                {
                    highest = x;
                }
                
            }
            return highest;

        }

        internal static int HighestForLoop(List<int> nums)
        {
            int highest = int.MinValue;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
                
            }
            return highest;
        }   

        internal static int HighestWhileLoop(List<int> nums)
        {
            int highest = int.MinValue;
            int i = 0;
            while (i < nums.Count)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
                i++;
            }
            return highest;
        }
    }
}
