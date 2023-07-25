using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherCalculations
{
    class Temperature : ITemperature
    {
        private List<int> temperatures = new List<int>();
        private Dictionary<string, int> words = new Dictionary<string, int>();

        public int Min { get; private set; } = int.MaxValue;
        public int Max { get; private set; } = int.MinValue;
        public double Average => Sum / (double)Count;

        private int Sum { get; set; }
        private int Count { get; set; }

        public Temperature()
        {
            words.Add("one", 1);
            words.Add("two", 2);
            words.Add("three", 3);
            words.Add("four", 4);
            words.Add("five", 5);
            words.Add("six", 6);
            words.Add("seven", 7);
            words.Add("eight", 8);
            words.Add("nine", 9);
            words.Add("ten", 10);
        }

        public void Insert(int temperature)
        {
            temperatures.Add(temperature);
            if (temperature < Min)
            {
                Min = temperature;
            }
            if (temperature > Max)
            {
                Max = temperature;
            }
            Sum += temperature;
            Count++;
        }

        public void Insert(string temperature)
        {
            // We already have a dictionary,
            // we pass in temperature as a key
            // which gives us the value for it

            // the insert method has access to the 'words' dictionary because
            // words is a member of the temperature class. Remember that any method
            // within a class can access the class's members, including fields, properties and other methods
            temperature = temperature.ToLower();
            Insert(words[temperature]);

        }
    }
}
