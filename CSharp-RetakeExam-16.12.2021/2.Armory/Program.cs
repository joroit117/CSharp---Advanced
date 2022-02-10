using System;
using System.Threading.Tasks;
using System.Linq;

namespace ExamPreparation
{
    public class Program
    {
        static void Main()
        {
            int sizeOfTheArmory = int.Parse(Console.ReadLine());
            char[][] armory = new char[sizeOfTheArmory][];
            int goldCoinsSpent = 0;
            for (int i = 0; i < sizeOfTheArmory; i++)
            {
                var chars = Console.ReadLine().ToCharArray();
                armory[i] = chars;
            }

            int armyOfficerRow = 0;
            int armyOfficerColumn = 0;
            for (int i = 0; i < sizeOfTheArmory; i++)
            {
                for (int j = 0; j < armory[i].Length; j++)
                {
                    if (armory[i][j] == 'A')
                    {
                        armyOfficerRow = i;
                        armyOfficerColumn = j;
                    }
                }
            }

            while(goldCoinsSpent < 65)
            {
                int oldArmyOfficerRow = armyOfficerRow;
                int oldArmyOfficerColumn = armyOfficerColumn;
                string direction = Console.ReadLine();
                switch (direction)
                {
                    case "up":
                        armyOfficerRow--;
                        break;
                    case "down":
                        armyOfficerRow++;
                        break;
                    case "right":
                        armyOfficerColumn++;
                        break;
                    case "left":
                        armyOfficerColumn--;
                        break;
                }
                armory[oldArmyOfficerRow][oldArmyOfficerColumn] = '-';
                if (armyOfficerRow < 0 || armyOfficerRow > sizeOfTheArmory - 1 ||
                armyOfficerColumn < 0 || armyOfficerColumn > sizeOfTheArmory - 1)
                {
                    Console.WriteLine("I do not need more swords!");
                    break;
                }    
                if (armory[armyOfficerRow][armyOfficerColumn] == 'M')
                {
                    armory[armyOfficerRow][armyOfficerColumn] = '-';
                    for (int i = 0; i < sizeOfTheArmory; i++)
                    {
                        for (int j = 0; j < armory[i].Length; j++)
                        {
                            if (armory[i][j] == 'M')
                            {
                                armyOfficerRow = i;
                                armyOfficerColumn = j;
                            }
                        }
                    }
                    armory[armyOfficerRow][armyOfficerColumn] = 'A';
                }
                else if(armory[armyOfficerRow][armyOfficerColumn] == '-')
                {
                    armory[armyOfficerRow][armyOfficerColumn] = 'A';
                }
                else
                {
                    goldCoinsSpent += int.Parse(armory[armyOfficerRow][armyOfficerColumn].ToString());
                    armory[armyOfficerRow][armyOfficerColumn] = 'A';
                }
            }
            if(goldCoinsSpent >= 65)
                Console.WriteLine("Very nice swords, I will come back for more!");
            Console.WriteLine($"The king paid {goldCoinsSpent} gold coins.");
            for (int i = 0; i < sizeOfTheArmory; i++)
            {
                for (int j = 0; j < sizeOfTheArmory; j++)
                {
                    Console.Write(armory[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
