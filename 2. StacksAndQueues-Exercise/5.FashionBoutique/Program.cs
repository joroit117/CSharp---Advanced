using System;
using System.Collections.Generic;

namespace _5.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] clothesValuesInput = Console.ReadLine().Split();
            int rackCapacity = int.Parse(Console.ReadLine());
            int rackCapacityCopy = rackCapacity;
            Stack<int> clothesValues = new Stack<int>();
            int numberOfRacks = 1;

            for(int i = 0; i < clothesValuesInput.Length; i++)
            {
                clothesValues.Push(int.Parse(clothesValuesInput[i]));
            }

            while(clothesValues.Count > 0)
            {
                int currentDressValue = clothesValues.Pop();
                if(rackCapacityCopy - currentDressValue == 0)
                {
                    rackCapacityCopy -= currentDressValue;
                    numberOfRacks++;
                    rackCapacityCopy = rackCapacity;
                }
                else if(rackCapacityCopy - currentDressValue < 0)
                {
                    numberOfRacks++;
                    rackCapacityCopy = rackCapacity;
                    rackCapacityCopy -= currentDressValue;
                }
                else
                {
                    rackCapacityCopy -= currentDressValue;
                }
            }

            Console.WriteLine(numberOfRacks);
        }
    }
}
