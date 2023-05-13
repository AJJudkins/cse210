using System;
using System.Collections.Generic;
class Journal{
    public List<Entry> journal = new List<Entry>(){};
    public void displayJournal(Journal journal)
    {
        Entry[] entries = System.IO.File.ReadAllLines(journalEntries);

        foreach (var entry in entries)
        {
            string[] parts = entry.Split(";");

            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];
            
            Console.WriteLine($"{date} - {prompt}");
            Console.WriteLine($"{text}");
        }
    }
}