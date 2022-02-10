using System;
using System.Threading.Tasks;
using System.Linq;

namespace ExamPreparation
{
    public class Program
    {
        static void Main()
        {
            int armyArmor = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[][] field = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                var chars = Console.ReadLine().ToCharArray();
                field[i] = chars;
            }
            bool throneReached = false;

            int heroRow = 0;
            int heroColumn = 0;
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j] == 'A')
                    {
                        heroRow = i;
                        heroColumn = j;
                    }
                }
            }

            while(!throneReached && armyArmor > 0)
            {
                int oldHeroRow = heroRow;
                int oldHeroColumn = heroColumn;
                string[] command = Console.ReadLine().Split(' ');
                string direction = command[0];
                int enemyRow = int.Parse(command[1]);
                int enemyColumn = int.Parse(command[2]);
                field[enemyRow][enemyColumn] = 'O';
                switch (direction)
                {
                    case "up":
                        heroRow--;
                        break;
                    case "down":
                        heroRow++;
                        break;
                    case "right":
                        heroColumn++;
                        break;
                    case "left":
                        heroColumn--;
                        break;
                }
                if (field[heroRow][heroColumn] == 'M')
                {
                    armyArmor--;
                    throneReached = true;
                    field[heroRow][heroColumn] = '-';
                    field[oldHeroRow][oldHeroColumn] = '-';
                    break;
                }
                if (heroRow < 0 || heroColumn < 0)
                    armyArmor--;
                else
                {
                    field[oldHeroRow][oldHeroColumn] = '-';
                    armyArmor--;
                    if (field[heroRow][heroColumn] == 'O')
                        armyArmor -= 2;
                    if (armyArmor > 0)
                        field[heroRow][heroColumn] = 'A';
                    else
                        field[heroRow][heroColumn] = 'X';
                }
            }

            if(throneReached)
            {
                Console.WriteLine($"The army managed to free the Middle World! Armor left: {armyArmor}");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < field[i].Length; j++)
                    {
                        Console.Write(field[i][j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"The army was defeated at {heroRow};{heroColumn}.");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < field[i].Length; j++)
                    {
                        Console.Write(field[i][j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
