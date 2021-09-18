using System;
using System.Collections.Generic;

namespace _4.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string strExpression = Console.ReadLine();
            Stack<int> oBrackets = new Stack<int>();

            for(int i = 0; i < strExpression.Length; i++)
            {
                if (strExpression[i] == '(')
                {
                    oBrackets.Push(i);
                }
                else if (strExpression[i] == ')')
                {
                    var vOpenBracket = oBrackets.Pop(); ;
                    var vCloseBracket = i;
                    Console.WriteLine(strExpression.Substring(vOpenBracket, vCloseBracket - vOpenBracket + 1));
                }
            }
        }
    }
}
