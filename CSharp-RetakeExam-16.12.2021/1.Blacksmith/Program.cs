using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetakeExam
{
    public class Program
    {
        static void Main()
        {
            LinkedList<int> steelValues = new LinkedList<int>();
            LinkedList<int> carbonValues = new LinkedList<int>();
            SortedDictionary<string, int> swords = new SortedDictionary<string,int>();
            string[] steels = Console.ReadLine().Split(' ');
            for (int i = 0; i < steels.Length; i++)
            {
                int temp = int.Parse(steels[i]);
                steelValues.AddLast(temp);
            }
            string[] carbons = Console.ReadLine().Split(' ');
            for (int j = 0; j < carbons.Length; j++)
            {
                int temp = int.Parse(carbons[j]);
                carbonValues.AddLast(temp);
            }
            while(steelValues.Count > 0 && carbonValues.Count > 0)
            {
                int sum = steelValues.First() + carbonValues.Last();
                switch (sum)
                {
                    case 70:
                        steelValues.RemoveFirst();
                        carbonValues.RemoveLast();
                        if (swords.ContainsKey("Gladius"))
                            swords["Gladius"]++;
                        else
                            swords.Add("Gladius", 1);
                        break;
                    case 80:
                        steelValues.RemoveFirst();
                        carbonValues.RemoveLast();
                        if (swords.ContainsKey("Shamshir"))
                            swords["Shamshir"]++;
                        else
                            swords.Add("Shamshir", 1);
                        break;
                    case 90:
                        steelValues.RemoveFirst();
                        carbonValues.RemoveLast();
                        if (swords.ContainsKey("Katana"))
                            swords["Katana"]++;
                        else
                            swords.Add("Katana", 1);
                        break;
                    case 110:
                        steelValues.RemoveFirst();
                        carbonValues.RemoveLast();
                        if (swords.ContainsKey("Sabre"))
                            swords["Sabre"]++;
                        else
                            swords.Add("Sabre", 1);
                        break;
                    case 150:
                        steelValues.RemoveFirst();
                        carbonValues.RemoveLast();
                        if (swords.ContainsKey("Broadsword"))
                            swords["Broadsword"]++;
                        else
                            swords.Add("Broadsword", 1);
                        break;
                    default:
                        steelValues.RemoveFirst();
                        int temp = carbonValues.Last();
                        carbonValues.RemoveLast();
                        carbonValues.AddLast(temp + 5);
                        break;
                }
            }
            int swordsCount = 0;
            foreach(var s in swords)
            {
                swordsCount += s.Value;
            }
            if (swords.Count >= 1)
                Console.WriteLine($"You have forged {swordsCount} swords.");
            else
                Console.WriteLine($"You did not have enough resources to forge a sword.");
            if(steelValues.Count > 0)
            {
                Console.Write("Steel left: ");
                for(int i = 0; i < steelValues.Count; i++)
                {
                    if(i != steelValues.Count - 1)
                        Console.Write(steelValues.ElementAt(i) + ", ");
                    else
                        Console.Write(steelValues.ElementAt(i));
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine("Steel left: none");
            if (carbonValues.Count > 0)
            {
                Console.Write("Carbon left: ");
                for (int i = carbonValues.Count - 1; i >= 0; i--)
                {
                    if (i != 0)
                        Console.Write(carbonValues.ElementAt(i) + ", ");
                    else
                        Console.Write(carbonValues.ElementAt(i));
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine("Carbon left: none");
            if(swords.Count > 0)
            {
                foreach(var s in swords)
                {
                    Console.WriteLine($"{s.Key}: {s.Value}");
                }
            }
        }
    }
}
