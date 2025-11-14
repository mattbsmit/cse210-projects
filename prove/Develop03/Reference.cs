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

    public void ScriptureReference(string book, int chapter, int verse)
    {
        string _book = book;
        int _chapter = chapter;
        int _verse = verse;
    }

    public void ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        string _book = book;
        int _chapter = chapter;
        int _startVerse = startVerse;
        int _endVerse = endVerse;
    }
}