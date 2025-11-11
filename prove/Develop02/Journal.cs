// Responsibility - Add Entry, Display Entries, Save File, Load File
// Method - void Display(), void AddEntry(), void SaveFile(), void ReadFile()
// Attributes - List_entries: Entry

using System;
using System.IO;

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void Display()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void SaveFile(Entry entry)
    {
        string fileName = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{entry._date}, {entry._prompt}, {entry._userEntry}");
        }


    }

    public void ReadFile()
    {
        string fileName = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];

            Console.WriteLine($"{date}, {prompt}, {entry}");
        }
    }

}