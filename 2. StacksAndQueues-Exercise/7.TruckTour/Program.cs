using System;
using System.Collections.Generic;

namespace _7.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> difference = new Queue<int>();
            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int amountOfPetrol = int.Parse(input[0]);
                int distanceToNextPetrolPump = int.Parse(input[1]);

                difference.Enqueue(amountOfPetrol - distanceToNextPetrolPump);
            }

            int position = 0;
            while(difference.Count > 0)
            {
                int current = difference.Dequeue();
                if(current >= 0)
                {
                    Queue<int> copy = new Queue<int>(difference);
                    int copyCurrent = current;
                    bool isFound = true;
                    while (copy.Count > 0)
                    {
                        int temp = copy.Dequeue();
                        if(copyCurrent + temp >= 0)
                        {
                            copyCurrent += temp;
                        }
                        else
                        {
                            isFound = false;
                            break;
                        }

                    }
                    if(isFound)
                    {
                        Console.WriteLine(position);
                        break;
                    }
                }
                else
                {
                    difference.Enqueue(current);
                }
                position++;
            }
        }
    }
}
