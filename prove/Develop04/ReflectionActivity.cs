using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    public class ReflectionActivity : Activity
    {
        private static readonly List<string> Prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private static readonly List<string> Questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What could you learn from this experience?",
            "What did you learn about yourself through this experience?"
        };

        public ReflectionActivity() : base("Reflection Activity",
            "This activity helps you reflect on times when you showed strength and resilience.") { }

        public override void Run()
        {
            Start();
            Random rand = new Random();
            string prompt = Prompts[rand.Next(Prompts.Count)];
            Console.WriteLine($"\n{prompt}");
            PauseWithAnimation(3);

            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            while (DateTime.Now < endTime)
            {
                string question = Questions[rand.Next(Questions.Count)];
                Console.WriteLine($"\n{question}");
                PauseWithAnimation(5);
            }

            End();
        }
    }
}
