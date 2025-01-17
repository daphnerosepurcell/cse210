using System;

using System.Collections.Generic;
using System.Reflection.Metadata;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input = -1;

        while (input != 0)

        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.Write("Enter number: ");

            string enternumber = Console.ReadLine();
            input = int.Parse(enternumber);

            if (input != 0)
            {
                numbers.Add(input);
            }
        }
            int sum = 0;
            
                foreach (int number in numbers)
                {
                    sum += number;
                }

            Console.WriteLine($"The sum is: {sum}");


            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            int max = numbers [0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine ($"The max is: {max}");

            }
        }
    
