using System;
using System.Collections.Generic;

namespace _3.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strElements = Console.ReadLine().Split();
            Stack<string> SElements = new Stack<string>();
            
            for (int i = 0; i < strElements.Length; i++)
            {
                SElements.Push(strElements[i]);
            }
            int nSumSub = 0;
            int nSumAdd = 0;
            int nNumber = 0;
            while (SElements.Count > 0)
            {
                var vElement = SElements.Pop();
                
                if(vElement == "+")
                {
                    nSumAdd += nNumber;
                    nNumber = 0;
                }
                else if(vElement == "-")
                {
                    nSumSub += nNumber;
                    nNumber = 0;
                }
                else
                {
                    nNumber = int.Parse(vElement);
                    if(SElements.Count == 0)
                    {
                        nSumAdd += nNumber;
                    }
                }
            }
            Console.WriteLine(nSumAdd - nSumSub);
        }
    }
}
