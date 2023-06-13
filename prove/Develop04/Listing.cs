class Listing : Activity
{
    private int responses = 0;
    private int duration;
    private List<string> prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    public Listing()
    {
    }

    public string getPrompt()
    {
        Random randomPrompt = new Random();
        int prompt = randomPrompt.Next(prompts.Count);
        return prompts[prompt];
    }
    public void runActivity()
    {
        Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for you session? ");
        duration = int.Parse(Console.ReadLine());

        startActivity();

        Console.WriteLine("List as many responses as you can to the following propmt:");
        Console.WriteLine();
        Console.WriteLine($"----- {getPrompt()} -----");
        Console.Write($"You may begin in:");
        Countdown(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (futureTime > DateTime.Now)
        {
            Console.WriteLine("> ");
            Console.ReadLine();
            responses ++;
        }

        Console.WriteLine($"You listed {responses} items");

        endActivity();

        Console.WriteLine($"You have completed {duration} seconds of the breathing activty.");
        ShowSpinner(5);
    }
}