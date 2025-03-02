using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Activity> activities = new Dictionary<string, Activity>
            {
                { "1", new BreathingActivity() },
                { "2", new ReflectionActivity() },
                { "3", new ListingActivity() }
            };

            while (true)
            {
                if (Console.IsOutputRedirected == false && Console.IsErrorRedirected == false)
                {
                    Console.Clear();
                }

                Console.WriteLine("=== Mindfulness Program ===");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                if (choice == "4")
                {
                    Console.WriteLine("Goodbye! Stay mindful.");
                    break;
                }
                else if (activities.ContainsKey(choice))
                {
                    activities[choice].Run();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    System.Threading.Thread.Sleep(1500);
                }
            }
        }
    }
}
