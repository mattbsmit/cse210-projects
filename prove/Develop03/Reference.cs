// Responsibility - To hold the reference for Scriptures.cs
// Method - void display
// Attributes - -string book, -int chapter, -int startVerse, -int endVerse
// Constructor - +ScriptureReerence(string name, int capter, int verse) +

class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;

    public string ScriptureReference(string book, int chapter, int verse)
    {
        string _book = book;
        string _chapter = chapter.ToString();
        string _verses = verse.ToString();

        string _reference = ($"{_book} {_chapter}:{_verses}");
        return _reference;
    }


/*
    public string ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        string _book = book;
        int _chapter = chapter;
        int _startVerse = startVerse;
        int _endVerse = endVerse;
        //string _verses = ("{_startVerse} + {_endVerse}");

        //return _book, _chapter, _verses;
    }*/
}