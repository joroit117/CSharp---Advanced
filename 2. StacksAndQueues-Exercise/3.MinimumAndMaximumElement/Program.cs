using System;
using System.Collections.Generic;

namespace _3.MinimumAndMaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            Stack<int> numbers2 = new Stack<int>();
            int max = Int32.MinValue;
            int min = Int32.MaxValue;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                switch (int.Parse(input[0]))
                {
                    case 1:
                        int temp = int.Parse(input[1]);
                        numbers.Push(temp);
                        break;
                    case 2:
                        if(numbers.Count != 0)
                        {
                            numbers.Pop();
                        }
                        break;
                    case 3:
                        if(numbers.Count != 0)
                        {
                            while (numbers.Count > 0)
                            {
                                int temp1 = numbers.Pop();
                                if (temp1 > max) max = temp1;
                                numbers2.Push(temp1);
                            }
                            Console.WriteLine(max);
                            while (numbers2.Count > 0)
                            {
                                numbers.Push(numbers2.Pop());
                            }
                        }
                        break;
                    case 4:
                        if(numbers.Count != 0)
                        {
                            while(numbers.Count > 0)
                            {
                                int temp1 = numbers.Pop();
                                if (temp1 < min) min = temp1;
                                numbers2.Push(temp1);
                            }
                            Console.WriteLine(min);
                            while (numbers2.Count > 0)
                            {
                                numbers.Push(numbers2.Pop());
                            }
                        }
                        break;
                }
            }
            while(numbers.Count > 0)
            {
                if(numbers.Count > 1)
                {
                    Console.Write(numbers.Pop() + ", ");
                }
                else
                {
                    Console.Write(numbers.Pop());
                }
            }
        }
    }
}
