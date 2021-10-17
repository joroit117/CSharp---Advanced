using System;
using System.Collections.Generic;

namespace _6.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> songsQueue = new Queue<string>();

            for(int i = 0; i < input.Length; i++)
            {
                songsQueue.Enqueue(input[i]);
            }

            while(true)
            {
                if (songsQueue.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }
                string[] command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "Play":
                        songsQueue.Dequeue();
                        break;
                    case "Add":
                        bool isContained = false;
                        string songAdded = "";
                        for(int i = 1; i < command.Length; i++)
                        {
                            if(i == command.Length - 1)
                            {
                                songAdded += command[i];
                            }
                            else
                            {
                                songAdded += command[i] + " ";
                            }
                        }
                        foreach(var song in songsQueue)
                        {
                            if(song == songAdded)
                            {
                                isContained = true;
                                break;
                            }
                        }
                        if(!isContained)
                        {
                            songsQueue.Enqueue(songAdded);
                        }
                        else
                        {
                            Console.WriteLine(songAdded + " is already contained!");
                        }
                        break;
                    case "Show":
                        int counter = 0;
                        foreach(var song in songsQueue)
                        {
                            if(counter < songsQueue.Count - 1)
                            {
                                Console.Write(song + ", ");
                            }
                            else
                            {
                                Console.Write(song);
                                Console.WriteLine();
                            }
                            counter++;

                        }
                        break;
                }
            }
        }
    }
}
