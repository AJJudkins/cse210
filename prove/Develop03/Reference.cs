class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    
    private int endVerse;
    public Reference(string bookName, int chapterNumber, int startVerseNumber, int endVerseNumber)
    {
        book = bookName;
        chapter = chapterNumber;
        startVerse = startVerseNumber;
        endVerse  = endVerseNumber;
    }

    public string formatedReference()
    {
        if (startVerse == endVerse)
        {
            string stringReference = book + " " + chapter+ ":" + startVerse;
            return stringReference;
        }
        else
        {
            string stringReference = book + " " + chapter + ":" + startVerse + "-" + endVerse;
            return stringReference;
        }
    }
}