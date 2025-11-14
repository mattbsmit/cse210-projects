// Responsibility - To remove words given by Scriptures.cs
// Method - void Hide, void Show, string getWord // Word(string word) IsHidden() bool, SetIsHidden(boolhidden), GetWord()string, DisplayWord() void
// Attributes - string word, bool hide
// Construtor - buildVerse

/*
Program.cs will be the main way that the user interacts with the program, mainly seeing what is displayed and using it to control
the enter or quit inputs. Scriputres.cs is going to hold all the text for each scripture while I'll use Reference.cs to store
all the parts of the reference. Using Word.cs, it will take a scripture and a reference from both Scriptures.cs and Reference.cs
and create a constructor with that. From there Word.cs will also handle making the scripture text randomly hide words while
keeping the reference untouched
*/


class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    
    public void HideWord()
    {
        _isHidden = true;
    }

    public string GetWord()
    {
        string hiddenWord = _word;

        if (_isHidden)
        {
            hiddenWord = new string('_', _word.Length);
        }

        Console.WriteLine(hiddenWord);
        return hiddenWord;
    }

    public void DisplayWord()
    {
        Console.WriteLine(_word);
    }
}