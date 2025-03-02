using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using System;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        entries.Add(new Entry(prompt, response));
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("\nNo journal entries found.");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
            Console.WriteLine("============================");
        }
    }

    public void SaveToFile(string filename)
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries to save.");
            return;
        }

        string json = JsonSerializer.Serialize(entries, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filename, json);
        Console.WriteLine($"Journal saved to {filename} (JSON format)");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string json = File.ReadAllText(filename);
        if (string.IsNullOrWhiteSpace(json))
        {
            Console.WriteLine("File is empty.");
            return;
        }

        entries = JsonSerializer.Deserialize<List<Entry>>(json) ?? new List<Entry>();
        Console.WriteLine($"Journal loaded from {filename} (JSON format)");
    }
}
