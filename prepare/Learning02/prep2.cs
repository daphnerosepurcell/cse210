using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your grade percentage? ");

            string input = Console.ReadLine();
            int grade = int.Parse(input);
            {

            if (grade >= 90)
                {
                    Console.WriteLine("You made an A.");
                }
                else if (grade >= 80 && grade < 90)
                {
                    Console.WriteLine("You made a B.");
                }
                else if (grade >= 70 && grade < 80)
                {
                    Console.WriteLine("You made a C.");
                }
                else if (grade >= 60 && grade < 70)
                {
                    Console.WriteLine("You made a D.");
                }
                else
                {
                    Console.WriteLine("You made an F.");
                }

            if (grade >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Don't give up! Keep trying and you'll do better next time.");
            }
            }
        }
    }
}
