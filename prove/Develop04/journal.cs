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

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}~|~{entry.Prompt}~|~{entry.Response}");
            }
        }

        Console.WriteLine($"Journal saved to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        if (lines.Length == 0)
        {
            Console.WriteLine("File is empty.");
            return;
        }

        entries.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            if (parts.Length == 3)
            {
                entries.Add(new Entry(parts[0], parts[1], parts[2]));
            }
            else
            {
                Console.WriteLine("Warning: Skipping an improperly formatted entry.");
            }
        }

        Console.WriteLine($"Journal loaded from {filename}");
    }
}
