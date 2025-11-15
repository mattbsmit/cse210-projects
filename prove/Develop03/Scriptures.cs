// Responsibility - To hold scriptures for Refence.cs and provide words to Word.cs
// Method - void display, void hide
// Attributes - string list scriptures
// Constructor - None

class Scripture
{
    private string scriptureText;
    public int userScripture = 1;

    List<string> scriptureList = new List<string>
    {
        "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
        "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",
        "",
    };

    public Scripture()
    {
        scriptureText = scriptureList[userScripture - 1];
        List<string> verseWords = scriptureText.Split(" ").ToList();
    }
}