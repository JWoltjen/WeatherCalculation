using System;
using WeatherCalculations;

class Program
{
    static void Main(string[] args)
    {
        
        ITemperature temperature = new Temperature();
        Random random = new Random();
        string[] words = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
        ConsoleKeyInfo input;
        do
        {
            // loop over temperature method to insert 100 temps
            for (int i = 0; i < 101; i++)
            {
                // the random insertion should be between 1 and 100
                temperature.Insert(random.Next(1, 101));
            }
            for (int i = 0; i < 100; i++)
            {
                temperature.Insert(words[random.Next(0, 10)]);
            }

            // output the min, max, and average values to the console
            Console.WriteLine($"Min temperature is {temperature.Min}");
            Console.WriteLine($"Max temperature is {temperature.Max}");
            Console.WriteLine($"Average temperature is {temperature.Average}");
            Console.WriteLine();
            Console.WriteLine("Press 'q' to quit, any other key to continue");

            input = Console.ReadKey();
        }
        while (input.Key != ConsoleKey.Q);
    }
}

