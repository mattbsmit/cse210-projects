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
        _date = DateTime.Now.ToString("MM/d/yyyy");

        Random randomIndex = new Random();
        String[] promptList = {"How is your day? ", "What is the most interesting thing you did today? "};
        List<string> promptIndex = new List<String>(promptList);

        int index = randomIndex.Next(0, 4);
        _prompt = promptList[index];

        Console.Write($"{_prompt}");
        _userEntry = Console.ReadLine();
    }

}