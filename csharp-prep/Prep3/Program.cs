using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        
        int numberguess = -1;
        


        while (magic != numberguess)

        {
            Console.Write("What is your guess? ");
            numberguess = int.Parse(Console.ReadLine());

             if (magic > numberguess)
            {
                Console.WriteLine("higher");
            }
            else if (numberguess > magic)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }   
    
}