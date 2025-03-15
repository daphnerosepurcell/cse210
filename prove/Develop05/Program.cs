using System;
using System.Collections.Generic;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;

    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine($"\nYour current score: {totalScore}\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoals(); break;
                case 3: RecordEvent(); break;
                case 4: Console.WriteLine("Save feature not implemented yet."); break;
                case 5: Console.WriteLine("Load feature not implemented yet."); break;
                case 6: Console.WriteLine("Exiting..."); break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Types of Goals:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select goal type: ");

        if (!int.TryParse(Console.ReadLine(), out int type))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
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
                Console.Write("Enter required times: ");
                int reqTimes = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, desc, points, reqTimes, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        int idx = 1;
        foreach (var goal in goals)
        {
            Console.WriteLine($"{idx}. {goal.Display()}");
            idx++;
        }
    }

    static void RecordEvent()
    {
        ListGoals();
        Console.Write("\nEnter goal number to record: ");
        if (int.TryParse(Console.ReadLine(), out int num) && num <= goals.Count && num > 0)
        {
            Goal goal = goals[num - 1];
            int pointsEarned = goal.RecordEvent();
            totalScore += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
}