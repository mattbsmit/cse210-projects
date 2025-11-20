// Responsibility - Hold Data
// Method - void Display(), void SetInfo(date, prompt, userEntry), void CreateEntry()
// Attributes - Date:String, Prompt:String, UserEntry:string 

using System;
using System.Security.Cryptography;

class Entry
{
    public string _date;
    public string _prompt;
    public string _userEntry;

    private int index;

    Random random = new Random();


    public void Display()
    {
        Console.WriteLine($"{_date}, {_prompt}, {_userEntry}");
    }

    /*public string SetInfo(string _date, string _prompt, string userEntry)
    {
        _date = _date;
        _prompt = _prompt;
        _userEntry = userEntry;
        return (_date, _prompt, _userEntry);
    }*/

    public void CreateEntry()
    {
        _date = DateTime.Now.ToString("MM/d/yyyy");

        Random randomIndex = new Random();
        String[] promptList = {"How is your day? ", "What is the most interesting thing you did today? ", "What are your plans for tomorrow? ", "What did you have for lunch today? ", "What was your least favorite part of the day? "};
        List<string> promptIndex = new List<String>(promptList);

        int index = randomIndex.Next(0, 4);
        _prompt = promptList[index];

        Console.Write($"{_prompt}");
        _userEntry = Console.ReadLine();
    }

}