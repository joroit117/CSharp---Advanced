using System;
using System.Collections.Generic;

namespace _8.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> parentheses = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                parentheses.Push(input[i]);
            }


        }
    }
}
