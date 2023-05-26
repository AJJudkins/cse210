class Word
{
    private string _letters;
    private bool isHidden;

    public void Hide()
    {
        isHidden = true;
    }

    public Word(string letters)
    {
        _letters = letters;
        isHidden = false;
    }

    public string getText()
    {
        if (isHidden){
            string underscores = "";
            int numLetters = _letters.Length;
            for (int i = 0; i < numLetters; i++){
                underscores += "_";
            }
            return underscores;
        }
        else{
            return _letters;
        }
    }

    public bool getIsHidden()
    {
        return isHidden;
    }
}
