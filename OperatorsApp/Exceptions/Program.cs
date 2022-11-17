namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;
            string fileName = "";

            try
            {
                text = File.ReadAllText(fileName);
                Console.WriteLine(text);
            }
            
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"Sorry {fileName} could not be found");
            }
            catch (ArgumentException e) 
            {
                Console.WriteLine("An empty filename was supplied");
            }
            catch (Exception e)
            {
                Console.WriteLine("Generally handled");
            }
            finally
            {
                Console.WriteLine("We made it here!");
            }
        }
    }
}