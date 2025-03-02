using System;
using System.Threading;

namespace MindfulnessProgram
{
    public abstract class Activity
    {
        protected string Name;
        protected string Description;
        protected int Duration;

        public Activity(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void Start()
        {
            
            if (Console.IsOutputRedirected == false && Console.IsErrorRedirected == false)
            {
                Console.Clear();
            }

            Console.WriteLine($"Starting {Name}...\n{Description}");

            Console.Write("Enter duration in seconds: ");
            while (!int.TryParse(Console.ReadLine(), out Duration) || Duration <= 0)
            {
                Console.Write("Invalid input. Please enter a positive number: ");
            }

            Console.WriteLine("Prepare to begin...");
            PauseWithAnimation(3);
        }

        public void End()
        {
            Console.WriteLine($"\nGreat job! You completed {Name} for {Duration} seconds.");
            PauseWithAnimation(3);
        }

        protected void PauseWithAnimation(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        public abstract void Run();
    }
}
