// Responsibility - To hold scriptures for Refence.cs and provide words to Word.cs
// Method - void display, void hide
// Attributes - string list scriptures
// Constructor - None

class Scripture
{
    private string scriptureText;

    List<string> scriptureList = new List<string>
    {
        "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
        "",
        "",
    };

    public Scripture(){
        string scriptureText = scriptureList[0];
        List<string> verseWords = scriptureText.Split(" ").ToList();
    }
}