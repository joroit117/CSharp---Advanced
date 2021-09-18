using System;
using System.Collections.Generic;

namespace _8.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> oCars = new Queue<string>();
            int nCarsPassPossible = int.Parse(Console.ReadLine());
            int nTotalCarsPassed = 0;
            while(true)
            {
                string command = Console.ReadLine();
                if(command == "end")
                {
                    Console.WriteLine(nTotalCarsPassed + " cars passed the crossroads.");
                    break;
                }
                if(command == "green")
                {
                    int nTemp = oCars.Count;
                    if(nTemp > nCarsPassPossible)
                    {
                        for (int i = 0; i < nCarsPassPossible; i++)
                        {
                            Console.WriteLine(oCars.Dequeue() + " passed!");
                            nTotalCarsPassed++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < nTemp; i++)
                        {
                            Console.WriteLine(oCars.Dequeue() + " passed!");
                            nTotalCarsPassed++;
                        }
                    }
                    
                }
                else
                {
                    oCars.Enqueue(command);
                }
            }
        }
    }
}
