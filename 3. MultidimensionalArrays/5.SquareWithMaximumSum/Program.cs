using System;

namespace _5.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int[,] matrix = new int[m, n];
            int[,] biggestMatrix = new int[2, 2];
            int biggestSum = 0;

            for (int i = 0; i < m; i++)
            {
                string[] line = Console.ReadLine().Split(", ");
                for (int j = 0; j < line.Length; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }
            
            for(int i = 0; i < m - 1; i++)
            {
                for(int j = 0; j < n - 1; j++)
                {
                    int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    biggestSum = biggestMatrix[0, 0] + biggestMatrix[0, 1] + biggestMatrix[1, 0] + biggestMatrix[1, 1];
                    if(currentSum > biggestSum)
                    {
                        biggestMatrix[0, 0] = matrix[i, j];
                        biggestMatrix[0, 1] = matrix[i, j + 1];
                        biggestMatrix[1, 0] = matrix[i + 1, j];
                        biggestMatrix[1, 1] = matrix[i + 1, j + 1];
                        biggestSum = currentSum;
                    }
                }
            }
            Console.WriteLine(biggestMatrix[0, 0] + " " + biggestMatrix[0, 1]);
            Console.WriteLine(biggestMatrix[1, 0] + " " + biggestMatrix[1, 1]);
            Console.WriteLine(biggestSum);
        }
    }
}
