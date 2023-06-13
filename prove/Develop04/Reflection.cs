class Reflection : Activity
{
    private int duration;
    private int reflectionDuration = 10;

    private List<string> prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public Reflection()
    {
    }

    public string getPrompt()
    {
        Random randomPrompt = new Random();
        int prompt = randomPrompt.Next(prompts.Count);
        return prompts[prompt];
    }

    public string getQuestion()
    {
        Random randomQuestion = new Random();
        int question = randomQuestion.Next(questions.Count);
        return questions[question];
    }

    public void runActivity()
    {
        Console.WriteLine("Welcome to the Reflecting Activity.");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for you session? ");
        duration = int.Parse(Console.ReadLine());

        startActivity();

        Console.WriteLine("Consider the following propmt:");
        Console.WriteLine();
        Console.WriteLine($"----- {getPrompt()} -----");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder each of the following questions as they relate to this experience.");


        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (futureTime > DateTime.Now)
        {
            Console.WriteLine($"> {getQuestion()}");
            ShowSpinner(reflectionDuration);
        }

        endActivity();

        Console.WriteLine($"You have completed {duration} seconds of the reflection activty.");
        ShowSpinner(5);
    }
}