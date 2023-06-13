using System;

class Program
{  
      static void Main(string[] args)
    {
      bool quit = false;

      while (quit != true)
      {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1. Start breathing activity");
        Console.WriteLine("   2. Start reflection activity");
        Console.WriteLine("   3. Start listing activity");
        Console.WriteLine("   4. Quit");
        Console.Write("Select a choice from the menu: ");
        int answer = int.Parse(Console.ReadLine());

        if (answer == 1)
        {
            var breathing = new Breathe();
            breathing.runActivity();
        }
        else if (answer == 2)
        {
            var reflection = new Reflection();
            reflection.runActivity();
        }
        else if (answer == 3)
        {
            var listing = new Listing();
            listing.runActivity();
        }
        else if (answer == 4)
        {
          quit = true;
        }
        else 
        {
          Console.WriteLine("That is not a valid selection. Please try again.");
        }
      }
    }
}