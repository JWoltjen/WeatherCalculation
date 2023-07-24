using System;

class Program
{
    static void Main(string[] args)
    {
        
        var temperature = new Temperature();
        var random = new Random();
        ConsoleKeyInfo input;
        do
        {
            // loop over temperature method to insert 100 temps
            for (int i = 0; i < 101; i++)
            {
                // the random insertion should be between 1 and 100
                temperature.Insert(random.Next(1, 101));
            }
            // output the min, max, and average values to the console
            Console.WriteLine($"Min temperature is {temperature.Min}");
            Console.WriteLine($"Max temperature is {temperature.Max}");
            Console.WriteLine($"Average temperature is {temperature.Average:F2}");
            Console.WriteLine();
            Console.WriteLine("Press 'q' to quit, any other key to continue");

            input = Console.ReadKey();
        }
        while (input.Key != ConsoleKey.Q);
    }
}

class Temperature
{
    // create properties for min, max, average, sum, and count
    public int Min { get; private set; } = int.MaxValue;
    public int Max { get; private set; } = int.MinValue;
    public double Average => Sum / (double)Count;

    private int Sum { get; set; }
    private int Count { get; set; }
   // create a method to insert random temperatures from 1 to 100
   public void Insert(int temperature)
    {
        if(temperature < Min)
        {
            Min = temperature;
        }
        if(temperature > Max)
        {
            Max = temperature;
        }
        Sum += temperature;
        Count++;
    }
}