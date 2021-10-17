using System;

namespace _3.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = i; j < n; j++)
                {
                    if(i == j)
                    {
                        sum += matrix[i, j];
                        break;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
