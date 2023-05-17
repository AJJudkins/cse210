using System;
using System.Collections.Generic;
class Journal{
    public List<Entry> entries = new List<Entry>(){};

    public void Add(Entry entry){
        entries.Add(entry);
    }
    public void displayJournal(Journal journal)
    {

        foreach (var entry in entries)
        {
            Console.WriteLine($"{entry._date} - {entry._prompt}");
            Console.WriteLine($"{entry._text}");
        }
    }
}