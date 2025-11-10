// Responsibility - Add Entry, Display Entries, Save File, Load File
// Method - void Display(), void AddEntry(), void SaveFile(), void ReadFile()
// Attributes - List_entries: Entry

using System;

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

    public void SaveFile(string fileName)
    {
        
    }

    public void ReadFile()
    {

    }

}