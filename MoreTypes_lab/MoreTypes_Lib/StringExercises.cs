using System;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            string firstName = input.ToUpper().Trim();

            string totalNums = "";
            for (int i = 0; i < num; i++)
            {   
                
                totalNums +=$"{i}";
            }

            return firstName + totalNums;
            
            
        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            string doorNum = number.ToString();
            string FullAddress = $"{doorNum} {street}, {city} {postcode}.";
            return FullAddress;
            
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            double finalScore = ((double) score / (double) outOf) * 100;
            double finalScoreRnded = Math.Round(finalScore, 1);
            string result = $"You got {score} out of {outOf}: {finalScoreRnded}%";
            return result;
            
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            double result;
            bool success = double.TryParse(numString, out result);
            if (success)
            {
                return result;
            }
            return - 999;
            
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int ACount = 0;
            int BCount = 0;
            int CCount = 0;
            int DCount = 0;

            foreach (char letter in input)
            {
                if (letter == 'A') 
                {
                    ACount++;
                }
                else if (letter == 'B')
                {
                    BCount++;
                }
                else if (letter == 'C')
                {
                    CCount++;
                }
                else if (letter == 'D')
                {
                    DCount++;
                }
            }

            return $"A:{ACount} B:{BCount} C:{CCount} D:{DCount}";
        }
    }
}
