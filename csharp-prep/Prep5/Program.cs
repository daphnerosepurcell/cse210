using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    //Asks for and returns the user's favorite number (as an integer)
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int number)
    // - Accepts an integer as a parameter and returns that number squared (as an integer)
    {
        int sqr = number * number;

        return sqr;
    }
    static void DisplayResult(string userName, int sqr)
    // - Accepts the user's name and the squared number and displays them.
    {
        Console.WriteLine($"{userName}, the square of your number is {sqr}");
    }
}