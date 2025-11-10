// Responsibility - Hold Data
// Method - void Display(), void SetInfo(date, prompt, userEntry), void CreateEntry()
// Attributes - Date:String, Prompt:String, UserEntry:string 

using System;

class Entry
{
    public string _date;
    public string _prompt;
    public string _userEntry;


    public void Display()
    {
        Console.WriteLine($"{_date}, {_prompt}, {_userEntry}");
    }

    public void SetInfo(string date, string prompt, string userEntry)
    {
        _date = date;
    }

    public void CreateEntry()
    {
        _date = "11/10/25";
        _prompt = "How was your day?";
        _userEntry = "Good";
    }

}