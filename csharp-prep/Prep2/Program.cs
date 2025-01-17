using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your grade?: ");
            
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 90)
            {
                Console.WriteLine("You made an A.");
            }
            else if (grade >= 80 && < 90 )
            {
                Console.WriteLine("You made an B.");
            }
             else if (grade >= 70 && < 80 )
            {
                Console.WriteLine("You made an C.");
            }
             else if (grade >= 60 && <70 )
            {
                Console.WriteLine("You made an D.");
            }
            else grade < 60
            {
                Console.WriteLine("You made an F.");
            }
        }
    }
}