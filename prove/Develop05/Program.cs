using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0;

        while (quit != true)
        {
            Console.WriteLine($"You have {totalPoints} points!");
            Console.WriteLine();

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Console.Clear();
                Console.WriteLine("There are three types of goals:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("What type of goal would you like to do?");
                int response = int.Parse(Console.ReadLine());

                if (response == 1)
                {
                    Console.Clear();

                    Console.Write("What is the name of your goal? ");
                    string simpleGoalName = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    string simpleGoalDescription = Console.ReadLine();
                    
                    Console.Write("What is the amount assosiated to this goal? ");
                    int simpleGoalPoints = int.Parse(Console.ReadLine());
                    
                    bool finished = false;
                    
                    Simple simpleGoal = new(simpleGoalName, simpleGoalDescription, simpleGoalPoints, finished);
                    goals.Add(simpleGoal);
                }
                else if (response == 2)
                {
                    Console.Clear();

                    Console.Write("What is the name of your goal? ");
                    string eternalGoalName = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    string eternalGoalDescription = Console.ReadLine();

                    Console.Write("What is the amount assosiated to this goal? ");
                    int eternalGoalPoints = int.Parse(Console.ReadLine());

                    Eternal eternalGoal = new(eternalGoalName, eternalGoalDescription, eternalGoalPoints);
                    
                    goals.Add(eternalGoal);
                }
                else if (response == 3)
                {
                    Console.Clear();
                
                    Console.Write("What is the name of your goal? ");
                    string checklistGoalName = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    string checklistGoalDescription = Console.ReadLine();
                    
                    Console.Write("What is the amount assosiated to this goal? ");
                    int checklistGoalPoints = int.Parse(Console.ReadLine());
                    
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int checklistNumber = int.Parse(Console.ReadLine());
                    
                    Console.Write("What is the bonus for accomplish at that many times? ");
                    int checklistBonus = int.Parse(Console.ReadLine());
                                                
                    int checkListCounter = 0;
                   
                    Checklist checklistGoal = new(checklistGoalName, checklistGoalDescription, checklistGoalPoints, checklistNumber, checklistBonus, checkListCounter);
                    
                    goals.Add(checklistGoal);
                }
                else
                {
                    Console.WriteLine("That is not a valid selection. Please try again.");
                }
            }
            else if (answer == 2)
            {
                Console.Clear();
                Console.WriteLine("The goals are: ");
                Console.WriteLine();
                
                int counter = 1;
                foreach (var goal in goals)
                {
                    Console.WriteLine(counter + ". " + goal.GetInformation());
                    counter++;
                }
            }
            else if (answer == 3)
            {
                Console.Clear();
                Console.Write("What is the filename for the goal file? ");
                string file = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(file))
                {
                    outputFile.WriteLine(totalPoints);

                    
                    foreach (var goal in goals)
                    {
                        outputFile.WriteLine(goal.GetString());
                    }
                }
            }
            else if (answer == 4)
            {
                Console.Clear();
                Console.Write("What is the filename for the goal file? ");
                string file = Console.ReadLine();
                string[] linesInFile = System.IO.File.ReadAllLines(file);
                string firstLine = linesInFile[0];
                totalPoints = int.Parse(firstLine);

                List<Goal> importedList = new List<Goal>();
                for (int i = 0; i < linesInFile.Length; i++)
                {
                    if (i != 0)
                    {
                        var parts = linesInFile[i].Split(':')[1].Split(',');

                        if (linesInFile[i].StartsWith("SimpleGoal:"))
                        {
                            Simple simpleGoal = new(parts[0], parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
                            importedList.Add(simpleGoal);

                            if (!importedList.Any(goal => goal.GetName() == simpleGoal.GetName()))
                            {
                                importedList.Add(simpleGoal);
                            }

                        }

                        else if (linesInFile[i].StartsWith("EternalGoal:"))
                        {
                            Eternal eternalGoal = new(parts[0], parts[1], int.Parse(parts[2]));

                            if (!importedList.Any(goal => goal.GetName() == eternalGoal.GetName()))
                            {
                                importedList.Add(eternalGoal);
                            }
                        }

                        else if (linesInFile[i].StartsWith("CheckListGoal:"))
                        {
                            Checklist checkListGoal = new(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                            importedList.Add(checkListGoal);

                            if (!importedList.Any(goal => goal.GetName() == checkListGoal.GetName()))
                            {
                                importedList.Add(checkListGoal);
                            }
                        }
                    }

                }

                goals = importedList;
            }
            else if (answer == 5)
            {
            }
            else if (answer == 6)
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