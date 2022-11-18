﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        static Exception emptyString = new Exception("Empty list");
        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            //if (nums == null || nums.Count == 0) throw new Exception("Empty list")

            try
            {
                return nums.Average();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            string ticketType = string.Empty;
            switch (age)
            {
                case >= 60:
                    ticketType = "OAP";
                    break;
                case >= 18:
                    ticketType = "Standard";
                    break;
                case >= 13:
                    ticketType = "Student";
                    break;
                case >= 5:
                    ticketType = "Child";
                    break;
                case >= 0:
                    ticketType = "Free";
                    break;
                default:
                    ticketType = "Error";
                    break;
            }
            return ticketType;


        }

        public static string Grade(int mark)
        {
            var grade = "";

            if (mark >= 60 && mark <= 100)
            {
                if (mark >= 75)
                {
                    grade = "Pass with Distinction";
                }
                else
                {
                    grade = "Pass with Merit";
                }
            }
            else 
            {
                if (mark >= 40)
                {
                    grade = "Pass";
                }
                else
                {
                    grade = "Fail";
                }
            }
            return grade;
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            int guests = 0;
            switch (covidLevel)
            {
                case 4:
                    guests = 20;
                    break;
                case 3:
                    guests = 50;
                    break;
                case 2:
                    guests = 50;
                    break;
                case 1:
                    guests = 100;
                    break;
                default:
                    guests = 200;
                    break;
            }
            return guests;
        }
    }
}
