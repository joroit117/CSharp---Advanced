using System;
using System.Collections.Generic;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main()
        {
            HashSet<string> codes = new HashSet<string>();
            while(true)
            {
                string input = Console.ReadLine();
                if (input == "PARTY")
                    break;
                codes.Add(input);
            }
            while(true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                    break;
                codes.Remove(input);
            }
            Console.WriteLine(codes.Count);
            foreach(var code in codes)
            {
                if (Char.IsDigit(code[0]))
                {
                    Console.WriteLine(code);
                    codes.Remove(code);
                }
            }
            foreach(var code in codes)
            {
                Console.WriteLine(code);
            }
        }
    }
}