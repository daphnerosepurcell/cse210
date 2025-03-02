using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    public class ListingActivity : Activity
    {
        private static readonly List<string> Prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity() : base("Listing Activity",
            "This activity helps you reflect on positive things by listing as many as you can.") { }

        public override void Run()
        {
            Start();
            Random rand = new Random();
            string prompt = Prompts[rand.Next(Prompts.Count)];
            Console.WriteLine($"\n{prompt}");
            PauseWithAnimation(3);

            List<string> responses = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            while (DateTime.Now < endTime)
            {
                Console.Write("Enter an item: ");
                responses.Add(Console.ReadLine());
            }

            Console.WriteLine($"\nYou listed {responses.Count} items!");
            End();
        }
    }
}
