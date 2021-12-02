using System;
using System.Collections.Generic;

namespace SetsAndDictionaries
{
    public class Program
    {
        static void Main()
        {
            SortedDictionary<string, Dictionary<string, double>> supermarket = new SortedDictionary<string, Dictionary<string, double>>();
            while(true)
            {
                string[] input = Console.ReadLine().Split(", ");
                if (input[0] == "Revision")
                    break;
                if(supermarket.ContainsKey(input[0]))
                {
                    supermarket[input[0]].Add(input[1], double.Parse(input[2]));
                }
                else
                {
                    supermarket.Add(input[0], new Dictionary<string, double>());
                    supermarket[input[0]].Add(input[1], double.Parse(input[2]));
                }
            }
            foreach(var item  in supermarket)
            {
                Console.WriteLine(item.Key + "->");
                foreach(var val in item.Value)
                {
                    Console.WriteLine("Product: " + val.Key + ", Price: " + val.Value);
                }
            }
        }
    }
}
