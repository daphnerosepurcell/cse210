using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;

    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine($"\nCurrent Score: {totalScore}");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");

            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoals(); break;
                case 3: RecordEvent(); break;
                case 4: SaveGoals(); break;
                case 5: LoadGoals(); break;
                case 6: Console.WriteLine("Goodbye!"); break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("\nTypes of Goals:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select goal type: ");

        int.TryParse(Console.ReadLine(), out int type);

        Console.Write("Goal Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                goals.Add(new SimpleGoal(name, desc, points));
                break;
            case 2:
                goals.Add(new EternalGoal(name, desc, points));
                break;
            case 3:
                Console.Write("Times to complete: ");
                int times = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, desc, points, times, bonus));
                break;
            default:
                Console.WriteLine("Invalid ");
                break;
        }
    }

    static void ListGoals()
    {
        if (goals.Count == 0)
    {
        Console.WriteLine("\nNo goals have been created yet.");
        return;
    }

    Console.WriteLine("\nYour Goals:");
    int i = 1;
    foreach (var goal in goals)
    {
        Console.WriteLine($"{i}. {goal.Display()}"); 
        i++;
    }
    }

    static void RecordEvent()
    {
        ListGoals();
        Console.Write("\nSelect goal number: ");
        int.TryParse(Console.ReadLine(), out int index);

        if (index > 0 && index <= goals.Count)
        {
            int earned = goals[index - 1].RecordEvent();
            totalScore += earned;
            Console.WriteLine($"You earned {earned} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            sw.WriteLine(totalScore);
            foreach (var goal in goals)
                sw.WriteLine(goal.SaveString());
        }
        Console.WriteLine("Goals saved!");
    }

    static void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");
        totalScore = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            switch (parts[0])
            {
                case "SimpleGoal":
                    goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                    break;
                case "EternalGoal":
                    goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                    break;
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }
}
