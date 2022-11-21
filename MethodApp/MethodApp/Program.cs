using System.ComponentModel.DataAnnotations;
using System.Diagnostics.SymbolStore;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace MethodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = DoThis(10, "sad");

            var myPizza = OrderPizza(true, false);
            var myPizza2 = OrderPizza(false, pineapple: true, mushrooms: true);

            var johnSmith = (FName:"John",lName: "Smith", age: 22);
            Console.WriteLine(johnSmith);
            Console.WriteLine(johnSmith.Item1);
            Console.WriteLine(johnSmith.Item2);
            Console.WriteLine(johnSmith.age);

            string firstName = "Jane";
            string lastName = "Doe";
            int age = 150;

            var janeDoe = (firstName, lastName, age);
            Console.WriteLine(janeDoe);

            var poundsToStones = GetStones(156);
            Console.WriteLine(poundsToStones);
        

        }

        public static int DoThis(int x, string y = "happy")
        {
            Console.WriteLine($"I'm feeling {y}");
            return x * x;
        }

        public static string OrderPizza(bool anchovies, bool pineapple, bool mushrooms = false, bool chilli = false, bool chicken = false, bool vegan = false)
        {
            var pizza = "Pizza with tomato sauce, cheese, ";
            if (anchovies) pizza += "anchovies, ";
            if (pineapple) pizza += "pineapple, ";
            if (mushrooms) pizza += "mushrooms, ";
            if (chilli) pizza += "chilli, ";
            if (chicken) pizza += "Chicken.";
            if (vegan)
            {
                anchovies = false;
                chicken = false;
            }
                
            return pizza;
        }

        public static (int multiply, int divide) AnotherMethod(int x, int y)
        {
            int multipy = x * y;
            int divide = x / y;

            return (multipy, divide);
        }

        public static (int stones, int pounds) GetStones(int x)
        {
            int stones = x / 14;
            int pounds = x % 14;

            return (stones, pounds);
        }
    }
}