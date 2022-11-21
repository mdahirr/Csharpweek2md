using System;

namespace Methods_Lib
{
    public class Methods
    {
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            if (totalDays < 0)
            {
                throw new ArgumentOutOfRangeException("totalDays must not be negative");
            }
                int weeks = totalDays / 7;
                int days = totalDays % 7;

                return (weeks, days);
            }
            
            //throw new NotImplementedException();

        }

        static int RollDice(Random rng)
        {
            int num1 = rng.Next(1, 7);
            int num2 = rng.Next(1, 7);
            return num1 + num2;
        }

        public static (int num1, num2) PowerRoot(int num1)
        {
            int squared = num1 * num1;
            int cubed = num1* num1* num1;
            
        }

    }
}
