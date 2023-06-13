class Breathe : Activity
{
    private int breatheInDuration = 5;
    private int breatheOutDuration = 5;
    private int duration;
    public Breathe()
    {
    }

    public void runActivity()
    {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for you session? ");
        duration = int.Parse(Console.ReadLine());

        startActivity();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (futureTime > DateTime.Now)
        {
            Console.WriteLine("Breathe in");
            Countdown(breatheInDuration);

            Console.WriteLine("Breathe out");
            Countdown(breatheOutDuration);
        }

        endActivity(); 

        Console.WriteLine($"You have completed {duration} seconds of the breathing activty.");
        ShowSpinner(5);
    }
}
