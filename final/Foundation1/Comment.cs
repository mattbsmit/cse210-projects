class Comment
{
    private string _commenter;
    private string _text;
    private string _fullComment;


    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
    }


    public string GetComment()
    {
        _fullComment = ($"Name: {_commenter}\nComment: {_text}");
        return _fullComment;
    }
}