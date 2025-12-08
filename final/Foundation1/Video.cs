class Video
{
    private string _title;
    private string _author;
    private int _length;
    private int _numberComments;
    private string _comment;


    List<string> comments = new List<string>();


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }


    public void DisplayVideo()
    {
        _numberComments = comments.Count;

        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nTime (seconds): {_length}\n# of Comments: {_numberComments}");
    }

    public void DisplayComments()
    {
        foreach (var i in comments)
        {
            Console.WriteLine(i.ToString());
        }
    }

    public void GetComment(string commenter, string text)
    {
        Comment comment = new Comment(commenter, text);
        _comment = comment.GetComment();

        comments.Add(_comment);
    }
}