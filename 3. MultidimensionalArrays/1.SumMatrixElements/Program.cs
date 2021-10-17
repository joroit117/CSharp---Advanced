using System;

namespace _1.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rowsAndCols = Console.ReadLine().Split(", ");
            int rows = int.Parse(rowsAndCols[0]);
            int columns = int.Parse(rowsAndCols[1]);

            int[,] matrix = new int[rows, columns];

            for(int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                for(int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            int sum = 0;
            Console.WriteLine(rows);
            Console.WriteLine(columns);
            foreach(var num in matrix)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
