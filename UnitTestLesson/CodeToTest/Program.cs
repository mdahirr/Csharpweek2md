namespace CodeToTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int timeOfDay = 21;
            var output = Greeting(timeOfDay);
            Console.WriteLine(output);

        }

        public static string Greeting(int timeOfDay)
        {
            string greeting = " ";
            try
            {
                if (timeOfDay >= 5 && timeOfDay <= 12)
                {
                    greeting = "Good morning!";
                }
                else if (timeOfDay > 12 && timeOfDay <= 18)
                {
                    greeting = "Good afternoon!";
                }
                else
                {
                    greeting = "Good evening!";
                }
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            

            return greeting;
        }

        public static string AvailableClassifications(int ageOfViewer)
        {
            string result = "";
            try
            {
                
                if (ageOfViewer < 12)
                {
                    result = "U and PG films are available.";
                }
                else if (ageOfViewer < 15 && ageOfViewer >= 12)
                {
                    result = "U, PG and 12 films are available.";
                }
                else if (ageOfViewer >= 15 && ageOfViewer < 18)
                {
                    result = "U, PG, 12 and 15 films are available.";
                }
                else
                {
                    result = "All films are available.";
                }
            }
            catch (ArgumentException e) 
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
    }
}