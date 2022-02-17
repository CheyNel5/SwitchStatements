using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine(); //evaluate to a string

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is awesome!");
                    break;
                case "science":
                    Console.WriteLine("Science is a very hard subject to learn.");
                    break;
                case "art":
                    Console.WriteLine("Art is my favorite subject!");
                    break;
                case "history":
                    Console.WriteLine("History is a very important subject to learn.");
                    break;
                case "english":
                    Console.WriteLine("I like English class too!");
                    break;
                default:
                    Console.WriteLine($"Interesting, I have never taken that subject before.  {subject} sounds fun!");
                    break;
            }
        }
    }
}
