using System;

class Video
{
    private string _videoName;
    private int _videoLength;
    private string _author;
    protected List<string> _comments = new List<string>();

    public Video(string videoName, int videoLength, string author, List<string> comments)
    {
        _videoName = videoName;
        _videoLength = videoLength;
        _author = author;
        _comments = comments;
    }

    public void displayInformation()
    {
        Console.WriteLine($"{_videoName}, {_videoLength}, {_author} {NumberOfComments()}");
        foreach (var comment in _comments)
        {
           Console.WriteLine(comment);
        }
        
    }

    public int NumberOfComments()
    {
       int counter = 0;

       foreach (var comment in _comments)
       {
            counter++;
       }

       return counter;
    
    }
}