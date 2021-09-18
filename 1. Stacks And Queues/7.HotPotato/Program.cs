using System;
using System.Collections.Generic;

namespace _7.HotPotato
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] strChildren = Console.ReadLine().Split();
            int nNum = int.Parse(Console.ReadLine());
            Queue<string> oChildren = new Queue<string>();

            for(int i = 0; i < strChildren.Length; i++)
            {
                oChildren.Enqueue(strChildren[i]);
            }

            while(oChildren.Count > 1)
            {
                int nTemp = nNum;
                while(nTemp > 1)
                {
                    oChildren.Enqueue(oChildren.Dequeue());
                    nTemp--;
                }
                Console.WriteLine("Removed " + oChildren.Dequeue());
            }
            Console.WriteLine("Last is " + oChildren.Dequeue());
        }
    }
}
