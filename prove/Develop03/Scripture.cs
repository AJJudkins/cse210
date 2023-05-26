class Scripture
{
    private string reference;
    private string scripture;
    private List<Word> _words;
    public Scripture(string referenceString, string scriptureText)
    {
        _words = new List<Word>();
        reference = referenceString;
        scripture = scriptureText;

        string[] words = scripture.Split(" ");
        foreach (var w in words)
        {
            var wordObj = new Word(w);
            _words.Add(wordObj);
        }
    }

    public void hideWords()
    {
        for (int i = 0; i < 3; i++)
        {
            Random randomWord = new Random();
            int word = randomWord.Next(_words.Count);
            _words[word].Hide();
        }
    }

    public void displayScripture()
    {
        Console.Write(reference + " ");
        foreach (var w in _words)
        {
            Console.Write(w.getText() + " ");
        }
    }

    public bool allIsHidden()
    {
        foreach (var w in _words)
        {
            if (w.getIsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}