using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//Extra: I made it so the program takes the scripture from the CSV file
class Program
{
static void Main()
{
    string filePath = @"C:\Users\dapsa\OneDrive\Documents\C+Git CSE 210\cse210\prove\Develop03\DC111.csv";
    Console.WriteLine($"Looking for file at: {filePath}"); 

    List<Scripture> scriptures = LoadScriptures(filePath);

    if (scriptures.Count == 0)
    {
        Console.WriteLine("No scriptures were loaded. Please check the file.");
        return;
    }

    Scripture scripture = scriptures[new Random().Next(scriptures.Count)];

    while (!scripture.IsFullyHidden())
    {
        scripture.Display();
        Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
        string input = Console.ReadLine().Trim().ToLower();
        if (input == "quit") break;
        scripture.HideWords();
    }

    Console.WriteLine("\nYou have successfully memorized the scripture!");
}
static List<Scripture> LoadScriptures(string filePath)
{
    List<Scripture> scriptures = new List<Scripture>();

    if (File.Exists(filePath))
    {
        string[] lines = File.ReadAllLines(filePath);
        foreach (string originalLine in lines)
        {
            Console.WriteLine($"Reading line: {originalLine}"); 

            if (!string.IsNullOrWhiteSpace(originalLine))
            {
                string line = originalLine.TrimEnd(';');

                string[] parts = line.Split(';');
                if (parts.Length == 2)
                {
                    string reference = string.Join(" ", parts[0].Split(','));
                    string text = string.Join(" ", parts[1].Split(','));

                    Console.WriteLine($"Parsed Reference: {reference}");
                    Console.WriteLine($"Parsed Text: {text}");

                    scriptures.Add(new Scripture(new ScriptureReference(reference), text));
                }
                else
                {
                    Console.WriteLine($"Skipping invalid line: {originalLine}");
                }
            }
        }
    }
    else
    {
        Console.WriteLine("File not found: " + filePath);
    }
    return scriptures;
}

}