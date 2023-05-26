using System;

class Program
{
    static void Main(string[] args)
    {
        string continueWord = "";
        bool stop = false;
        var newReference = new Reference("Moroni", 10, 4, 4);
        Scripture scripture = new Scripture(newReference.formatedReference(), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.");

        while (continueWord != "quit" || stop != false)
        {
            scripture.displayScripture();
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish ");
            continueWord = Console.ReadLine();
            scripture.hideWords();
            if (stop = scripture.allIsHidden())
            {
                break;
            };

            Console.Clear();
        }
    }
}
