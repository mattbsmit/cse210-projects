using System;

class Program
{
    static void Main(string[] args)
    {
        Menu journalMenu = new Menu();

        int userSelection;
        bool done = false;
        Entry newEntry = new Entry();

        do 
        {
            userSelection = journalMenu.ProcessMenu();

            switch(userSelection)
            {
                case 1:
                    newEntry.CreateEntry();
                    newEntry.Display();
                    break;
                case 2:
                    newEntry.Display();
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