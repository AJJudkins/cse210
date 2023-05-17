using System;

class Program
{
    static void Main(string[] args)
    {
        //This is the start of the menu code.
        int response = -1;
        var Journal = new Journal();
        
        while (response != 5){
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?");

            string userResponse = Console.ReadLine();
            response = int.Parse(userResponse);

            if (response == 1){

                // This is to get a prompt.
                var promptGenerator = new PromptGenerator();
                string prompt = promptGenerator.getPrompt();

                // This is to get the date as a string.
                DateTime _date = DateTime.Now;
                string dateText = _date.ToShortDateString();

                // This is to get the user's response.
                Console.WriteLine($"{dateText} - {prompt}");
                string text = Console.ReadLine();

                // This sends the information to the  entry class to format the entry.
                var Entry = new Entry( dateText, prompt, text);
                Journal.Add(Entry);
            } 
            else if (response == 2){

                // This is to display the journal.
                Journal.displayJournal(Journal);

            }
            else if (response == 3){

                // This is to load entries to the journal from a file.
                Console.Write("What is the name of the file that your would like to load? ");
                string fileName = Console.ReadLine();
                var load = new FileEditor();
                load.LoadJournal(Journal, fileName);
            }
            else if (response == 4){
                // This is to save the journal to a new file.
                Console.Write("What is the name of the file you would like to save to? ");
                string fileName = Console.ReadLine();
                var save = new FileEditor();
                save.SaveJournal(Journal, fileName);
            }
            else {
                response = 5;
            }
        }
        
    }
}