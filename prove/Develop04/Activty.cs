class Activity
{
    public void startActivity()
    {
        Console.WriteLine("Getting ready...");
        ShowSpinner(5);
    }
    public void endActivity()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(5);
    }

    public void ShowSpinner(int duration)
    {
        List<string> animations = new List<string>
        {
            "-",
            "\\",
            "|",
            "/",
        };

        var startTime = DateTime.Now;
        var endTime = startTime.AddSeconds(duration);

        int animationIndex = 0;
        while (DateTime.Now < endTime)
        {
            string frame = animations[animationIndex];
            Console.Write(frame);

            Thread.Sleep(250);

            Console.Write("\b \b");

            animationIndex++;
            if (animationIndex >= animations.Count)
            {
                animationIndex = 0;
            }
        }
    }
    public void Countdown(int duration)
    {
        int currentValue = duration;

        while (currentValue > 0)
        {
            Console.WriteLine(currentValue);
            Thread.Sleep(1000);
            currentValue--;
        }
    }
}