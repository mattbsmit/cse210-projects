using System;

class Program
{
    static void Main(string[] args)
    {
        Menu journalMenu = new Menu();
        Journal journal = new Journal();
        Entry entry = new Entry();

        int userSelection;
        bool done = false;

        
        do
        {
            userSelection = journalMenu.ProcessMenu();

            switch (userSelection)
            {
                case 1:
                    Entry newEntry = new Entry();
                    newEntry.CreateEntry();
                    journal.AddEntry(newEntry);
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    journal.SaveFile(entry);
                    break;
                case 4:
                    // string fileName = "journal.txt" add "fileName" to journal.ReadFile(fileName);
                    journal.ReadFile();
                    break;
                case 5:
                    done = true;
                    break;
            }
        } while (!done);
    }
}