using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();  
        Journal journal = new Journal();
        Prompt prompt = new Prompt();

        bool done = false;

        while (!done)
        {
            menu.Display();  
            Console.Write("\nEnter your choice: ");
            string input = Console.ReadLine();
            int option;

            if (!int.TryParse(input, out option))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            if (option == 1)
            {
                string selectedPrompt = prompt.GetRandom();
                Console.WriteLine("\nToday's Prompt: " + selectedPrompt);
                Console.Write("Your Response: ");
                string response = Console.ReadLine();
                journal.AddEntry(selectedPrompt, response);
            }
            else if (option == 2)
            {
                journal.DisplayEntries();
            }
            else if (option == 3)
            {
                Console.Write("Enter filename to load (e.g., journal.json): ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
            }
            else if (option == 4)
            {
                Console.Write("Enter filename to save (e.g., journal.json): ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
            }
            else if (option == 5)
            {
                Console.Write("Enter entry number to remove: ");
                int entryNumber;
                if (int.TryParse(Console.ReadLine(), out entryNumber))
                {
                    journal.RemoveEntry(entryNumber);
                }
                else
                {
                    Console.WriteLine("Invalid entry number.");
                }
            }
            else if (option == 6)
            {
                done = true;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
