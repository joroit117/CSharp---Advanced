using System;
using System.Collections.Generic;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main()
        {
            Dictionary<double, int> keyValues = new Dictionary<double, int>();
            string[] input = Console.ReadLine().Split();
            for(int i = 0; i < input.Length; i++)
            {
                double number = double.Parse(input[i]);
                if (keyValues.ContainsKey(number)) keyValues[number]++;
                else keyValues.Add(number, 1);
            }
            foreach(var key in keyValues)
            {
                Console.WriteLine(key.Key + " - " + key.Value + " times");
            }
        }
    }
}
