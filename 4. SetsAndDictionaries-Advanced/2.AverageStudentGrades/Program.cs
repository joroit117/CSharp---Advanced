using System;
using System.Collections.Generic;

namespace SetsAndDictionaries
{
    public class Program
    {
        static void Main()
        {
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if(students.ContainsKey(input[0]))
                {
                    students[input[0]].Add(decimal.Parse(input[1]));
                }
                else
                {
                    students.Add(input[0], new List<decimal>());
                    students[input[0]].Add(decimal.Parse(input[1]));
                }
            }
            foreach (var student in students)
            {
                decimal avg = 0;
                Console.Write(student.Key + " -> ");
                for(int i = 0; i < student.Value.Count; i++)
                {
                    avg += student.Value[i];
                    Console.Write($"{student.Value[i]:f2} ");
                }
                avg /= student.Value.Count;
                Console.WriteLine($"(avg: {avg:f2})");
            }

        }
    }
}
