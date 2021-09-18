using System;
using System.Collections.Generic;

namespace _5.WorkingWithQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> oNumbers = new Queue<int>();

            string[] strIntegers = Console.ReadLine().Split();

            for(int i = 0; i < strIntegers.Length; i++)
            {
                oNumbers.Enqueue(int.Parse(strIntegers[i]));
            }

            while(oNumbers.Count > 0)
            {
                int nNum = oNumbers.Dequeue();

                if(nNum % 2 == 0)
                {
                    if(oNumbers.Count == 0)
                    {
                        Console.Write(nNum);
                    }
                    else
                    {
                        Console.Write(nNum + ", ");
                    }           
                }
            }
        }
    }
}
