using System;

namespace _7.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var pascalTriangle = new long[n][];

            for (var row = 0; row < n; row++)
            {
                pascalTriangle[row] = new long[row + 1];
                pascalTriangle[row][0] = 1;
                pascalTriangle[row][^1] = 1;

                for (var col = 1; col < row; col++)
                {
                    pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
                }
            }

            for (var row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join(" ", pascalTriangle[row]));
            }
        }
    }
}
