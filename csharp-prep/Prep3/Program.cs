using System;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        int magic = generator.Next(1, 101);

        int guess = -1;

            while (guess != magic)
            {
            Console.Write("What is your guess?");
            string guess_text = Console.ReadLine();
            guess = int.Parse(guess_text);

            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("That is the magic number!");
            }
            }
    }
}