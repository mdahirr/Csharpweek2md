using System;
using System.Net.Http.Headers;

namespace MoreTypes_Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }
    public class DateTimeEnumsExercises
    {
        // returns a person's age at a given date, given their birth date.
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
            var month = date.Month - birthDate.Month;
            var age = date.Year - birthDate.Year;
            if (month < 0)
            {
                age -= 1;
            }
            if (birthDate > date)
            {
                throw new ArgumentException("Error - birthDate is in the future");
            }
            return age;
        }
        // returns a date formatted in the manner specified by the unit test
        public static string FormatDate(DateTime date)
        {
            string newdate = date.ToString("yy/dd/MMM");
            return newdate;
        }

        // returns the name of the month corresponding to a given date
        public static string GetMonthString(DateTime date)
        {
            string month = date.ToString("MMMM");
            return month;
        }

        // see unit tests for requirements
        public static string Fortune(Suit suit)
        {
            if (suit == Suit.CLUBS)
            {
                return "And the seventh rule is if this is your first night at fight club, you have to fight.";
            }
            else if (suit == Suit.SPADES)
            {
                return "Bucket and spade";
            }
            else if (suit == Suit.DIAMONDS)
            {
                return "Diamonds are a girls best friend";
            }
            else if (suit == Suit.HEARTS)
            {
                return "You've broken my heart";
            }

            return "nothing";
        }
    }
}
