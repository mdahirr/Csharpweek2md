﻿namespace HelloWorldApp

{
    public class Program

    {
        public static void Main(string[] args)
        {
            int x = 100;
            x += 10;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i: " + i + " -- x: " + x);

                x += 1;
            }

            foreach (var item in args)
            {
                Console.WriteLine(item);
            }
        }
    }
}