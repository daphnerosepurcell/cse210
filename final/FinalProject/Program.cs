using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Chord Finder.");

            while (true)
            {
                Console.Write("Enter a root note (ex: C, D#, F), or type 'exit': ");
                string root = Console.ReadLine().Trim().ToUpper();

                if (root == "EXIT")
                {
                    break;
                }

                Console.Write("Enter chord type (major, minor, diminished, augmented, seventh): ");
                string chordType = Console.ReadLine().Trim().ToLower();

                Chord chord = ChordFactory.GetChord(chordType, root);

                if (chord != null)
                {
                    chord.Build();
                    Console.WriteLine($"{chordType} chord for {root}:");

                    foreach (string note in chord.GetNotes())
                    {
                        Console.Write(note + " ");
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Not a valid chord type. Try again.");
                }

                Console.WriteLine();
            }
        }
    }