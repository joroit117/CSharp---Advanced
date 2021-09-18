using System;
using System.Collections;
using System.Collections.Generic;

namespace _6.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> oNames = new Queue<string>();

            while(true)
            {
                string command = Console.ReadLine();
                if(command == "End")
                {
                    Console.WriteLine(oNames.Count + " people remaining.");
                    break;
                }
                if(command == "Paid")
                {
                    while(oNames.Count > 0)
                    {
                        Console.WriteLine(oNames.Dequeue());
                    }
                }
                else
                {
                    oNames.Enqueue(command);
                }
            }
        }
    }
}
