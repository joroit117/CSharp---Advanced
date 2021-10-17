using System;

namespace _6.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                for(int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }

            while(true)
            {
                string[] input = Console.ReadLine().Split();
                if(input[0] == "END")
                    break;

                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                switch (input[0])
                {
                    case "Add":
                        if(row >= 0 && row < n && col >=0 && col < n)
                            matrix[row, col] += value;
                        else
                            Console.WriteLine("Invalid coordinates");
                        break;
                    case "Subtract":
                        if (row >= 0 && row < n && col >= 0 && col < n)
                            matrix[row, col] -= value;
                        else
                            Console.WriteLine("Invalid coordinates");
                        break;
                }

            }

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
