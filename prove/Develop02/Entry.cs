using System;

class Entry
{
    public string _text;
    public string _prompt;
    public string _date;

    public Entry(string date, string prompt, string text){
        // This is to format the entry to the proper way to be stored.
        _text = text;
        _prompt = prompt;
        _date = date;
    }
}