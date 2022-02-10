using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class Program
    {
        static void Main()
        {
            LinkedList<int> ingredientsValues = new LinkedList<int>();
            LinkedList<int> freshnessLevelValues = new LinkedList<int>();
            SortedDictionary<string, int> dishes = new SortedDictionary<string, int>();
            string[] ingredients = Console.ReadLine().Split(' ');
            for(int i = 0; i < ingredients.Length; i++)
            {
                int temp = int.Parse(ingredients[i]);
                ingredientsValues.AddLast(temp);
            }
            string[] freshnessLevel = Console.ReadLine().Split(' ');
            for(int j = 0; j < freshnessLevel.Length; j++)
            {
                int temp = int.Parse(freshnessLevel[j]);
                freshnessLevelValues.AddLast(temp);
            }
            while(ingredientsValues.Count > 0 && freshnessLevelValues.Count > 0)
            {
                if (ingredientsValues.First() == 0)
                    ingredientsValues.RemoveFirst();
                long multiplicationResult = ingredientsValues.First() * freshnessLevelValues.Last();
                switch (multiplicationResult)
                {
                    case 150:
                        ingredientsValues.RemoveFirst();
                        freshnessLevelValues.RemoveLast();
                        if(dishes.ContainsKey("Dipping sauce"))
                            dishes["Dipping sauce"]++;
                        else
                            dishes.Add("Dipping sauce", 1);
                        break;
                    case 250:
                        ingredientsValues.RemoveFirst();
                        freshnessLevelValues.RemoveLast();
                        if (dishes.ContainsKey("Green salad"))
                            dishes["Green salad"]++;
                        else
                            dishes.Add("Green salad", 1);
                        break;
                    case 300:
                        ingredientsValues.RemoveFirst();
                        freshnessLevelValues.RemoveLast();
                        if (dishes.ContainsKey("Chocolate cake"))
                            dishes["Chocolate cake"]++;
                        else
                            dishes.Add("Chocolate cake", 1);
                        break;
                    case 400:
                        ingredientsValues.RemoveFirst();
                        freshnessLevelValues.RemoveLast();
                        if (dishes.ContainsKey("Lobster"))
                            dishes["Lobster"]++;
                        else
                            dishes.Add("Lobster", 1);
                        break;
                    default:
                        freshnessLevelValues.RemoveLast();
                        ingredientsValues.AddFirst(ingredientsValues.Last() + 5);
                        ingredientsValues.RemoveLast();
                        break;
                }
            }
            int ingredientsLeft = 0;
            if (ingredientsValues.Count > 0)
            {
                while(ingredientsValues.Count > 0)
                {
                    ingredientsLeft += ingredientsValues.First();
                    ingredientsValues.RemoveFirst();
                }
            }
            if(dishes.Count >= 4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
                if(ingredientsLeft > 0)
                    Console.WriteLine($"Ingredients left: {ingredientsLeft}");
                foreach(var dish in dishes)
                {
                    Console.WriteLine($"#{dish.Key} --> {dish.Value}");
                }
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
                if (ingredientsLeft > 0)
                    Console.WriteLine($"Ingredients left: {ingredientsLeft}");
                foreach (var dish in dishes)
                {
                    if(dish.Value > 0)
                    {
                        Console.WriteLine($"#{dish.Key} --> {dish.Value}");
                    }
                }
            }
        }
    }
}
