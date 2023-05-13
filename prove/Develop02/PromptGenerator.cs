using System;

class PromptGenerator{

    List<string> prompts = new List<string>(){
        "What was the best thing about your day?",
        "What was your favorite part about your day?",
        "What are you thankful for today?",
        "What did you do to help someone else today?",
        "What was the best thing that you ate today?",
        "What was one thing that your learned today?",
        "What was one fun thing that you did today?"
    };
    public string getPrompt()
    {
        Random randomPrompt = new Random();
        int prompt = randomPrompt.Next(prompts.Count);
        return prompts[prompt];
    }
}