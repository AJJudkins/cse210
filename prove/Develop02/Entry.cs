using System;

class Entry
{
    public string _text;
    public string _prompt;
    public string _date;

    public void formatEntry(Journal journal, string _date, string _prompt, string _text){
        // This is to format the entry to the proper way to be stored.
        Entry entry = $"{_date};{_prompt};{_text};";

        journal.journal.Add(entry);
    }
}