using System;
using System.Collections.Generic;

namespace _1.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int S = int.Parse(input[1]);
            int X = int.Parse(input[2]);

            Stack<int> numbers = new Stack<int>();
            int smallestNum = Int32.MaxValue;

            string[] inputNums = Console.ReadLine().Split();

            for (int i = 0; i < N; i++)
            {
                int a = int.Parse(inputNums[i]);
                numbers.Push(a);
            }
            for(int i = 0; i < S; i++)
            {
                numbers.Pop();
            }
            if(numbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                bool isFound = false;
                while (numbers.Count > 0)
                {
                    int temp = numbers.Pop();
                    if (temp == X)
                    {
                        Console.WriteLine("true");
                        isFound = true;
                        break;
                    }
                    else
                    {
                        if (temp < smallestNum) smallestNum = temp;
                    }
                }
                if (!isFound)
                {
                    Console.WriteLine(smallestNum);
                }
            }
        }
    }
}
