using System;
using System.Collections.Generic;

namespace _2.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strIntegers = Console.ReadLine().Split();
            Stack<int> myStack = new Stack<int>();

            for(int i = 0; i < strIntegers.Length; i++)
            {
               myStack.Push(int.Parse(strIntegers[i]));
            }

            string[] command = Console.ReadLine().Split();

            while(!string.Equals(command[0], "end", StringComparison.CurrentCultureIgnoreCase))
            {
                if(string.Equals(command[0], "add", StringComparison.CurrentCultureIgnoreCase))
                {
                    myStack.Push(int.Parse(command[1]));
                    myStack.Push(int.Parse(command[2]));

                }
                else if (string.Equals(command[0], "remove", StringComparison.CurrentCultureIgnoreCase))
                {
                    if(int.Parse(command[1]) <= myStack.Count)
                    {
                        for (int i = 0; i < int.Parse(command[1]); i++)
                        {
                            myStack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().Split();
            }
            int nSum = 0;
            int nMyStackSize = myStack.Count;
            for(int i = 0; i < nMyStackSize; i++)
            {
                nSum += myStack.Pop();
            }
            Console.WriteLine("Sum: " + nSum);
        }
    }
}
