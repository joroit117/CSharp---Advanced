using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string strText = Console.ReadLine();
            Stack<char> sMyStack = new Stack<char>();
            for (int i = 0; i < strText.Length; i++)
            {
                sMyStack.Push(strText[i]);
            }
            while(sMyStack.Count() > 0)
            {
                Console.Write(sMyStack.Pop());
            }
            Console.WriteLine();
        }
    }
}
