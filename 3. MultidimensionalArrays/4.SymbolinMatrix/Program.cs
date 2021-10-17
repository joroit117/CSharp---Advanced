﻿using System;

namespace _4.SymbolinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = (char)input[j];
                }
            }
            char c = Char.Parse(Console.ReadLine());
            bool isFound = false;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(matrix[i, j] == c)
                    {
                        Console.WriteLine("(" + i + ", " + j + ")");
                        isFound = true;
                        break;
                    }
                }
            }
            if(!isFound)
            {
                Console.WriteLine(c + " does not occur in the matrix");
            }
        }
    }
}
