using System;

class Program
{
    static void Main(string[] args)
    {
        Menu journalMenu = new Menu();
        Journal journal= new Journal();

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
                    break;
                case 4:
                    break;
                case 5:
                    done = true;
                    break;
            }
        } while (!done);
    }
}