using System;

namespace _2.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rowsAndCols = Console.ReadLine().Split(", ");
            int rows = int.Parse(rowsAndCols[0]);
            int columns = int.Parse(rowsAndCols[1]);

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            for(int i = 0; i < columns; i++)
            {
                int sum = 0;
                for(int j = 0; j < rows; j++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
