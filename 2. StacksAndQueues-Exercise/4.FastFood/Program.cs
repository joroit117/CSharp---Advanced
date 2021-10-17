using System;
using System.Collections.Generic;

namespace _4.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            string[] orders = Console.ReadLine().Split();
            int max = Int32.MinValue;
            Queue<int> Orders = new Queue<int>();
            bool isComplete = true;

            foreach(var order in orders)
            {
                Orders.Enqueue(int.Parse(order));
            }
            while(Orders.Count > 0)
            {
                int temp = Orders.Dequeue();
                if (foodQuantity - temp > 0)
                {
                    if (temp > max) max = temp;
                    foodQuantity -= temp;
                }
                else
                {
                    Console.WriteLine(max);
                    Console.Write("Orders left: " + temp);
                    while(Orders.Count > 0)
                    {
                        Console.Write(" " + Orders.Dequeue());
                    }
                    isComplete = false;
                    break;
                }
            }
            if(isComplete)
            {
                Console.WriteLine(max);
                Console.WriteLine("Orders complete");
            }
        }
    }
}
