using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var parking = new HashSet<string>();
            while(input != "END")
            {
                var inputParams = Regex.Split(input, ", ");
                if(inputParams[0] == "IN")
                {
                    parking.Add(inputParams[1]);
                }
                else
                {
                    parking.Remove(inputParams[1]);
                }

                input = Console.ReadLine();
            }

            if(parking.Count == 0)
                Console.WriteLine("Parking Lot is Empty");
            else
            {
                foreach (var p in parking)
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
}