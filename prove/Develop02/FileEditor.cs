using System;
using System.Collections.Generic;

class FileEditor {

    public void SaveJournal(Journal journal, string filename){
        using (StreamWriter outputFile = new StreamWriter(filename)){
            foreach (var entry in journal.entries){
                string data = $"{entry._date};{entry._prompt};{entry._text};";
                outputFile.WriteLine(data);
            }
        }
    }
    public Journal LoadJournal(Journal journal, string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines){
            string[] parts = line.Split(";");

            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];

            Entry entry = new Entry(date, prompt, text);

            journal.entries.Add(entry);
        }

        return journal;
    }
}