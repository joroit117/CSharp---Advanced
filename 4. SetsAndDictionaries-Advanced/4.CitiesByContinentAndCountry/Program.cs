using System;
using System.Collections.Generic;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, List<string>>> ccc = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if(ccc.ContainsKey(input[0]))
                {
                    if(ccc[input[0]].ContainsKey(input[1]))
                    {
                        ccc[input[0]][input[1]].Add(input[2]);
                    }
                    else
                    {
                        ccc[input[0]].Add(input[1], new List<string>());
                        ccc[input[0]][input[1]].Add(input[2]);
                    }
                }
                else
                {
                    ccc.Add(input[0], new Dictionary<string, List<string>>());
                    ccc[input[0]].Add(input[1], new List<string>());
                    ccc[input[0]][input[1]].Add(input[2]);
                }
            }
            foreach(var c in ccc)
            {
                Console.WriteLine(c.Key + ":");
                foreach(var cc in c.Value)
                {
                    Console.Write(cc.Key + " -> ");
                    for(int i = 0; i < cc.Value.Count; i++)
                    {
                        if (i == cc.Value.Count - 1)
                        {
                            Console.WriteLine(cc.Value[i]);
                        }
                        else
                        {
                            Console.Write(cc.Value[i] + ", ");
                        }
                    }
                }
            }
        }
    }
}
