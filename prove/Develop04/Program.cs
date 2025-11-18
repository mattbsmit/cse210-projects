using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Menu activityMenu = new Menu();

        int userSelection;
        bool done  = false;

        do
        {
            userSelection = activityMenu.DisplayMenu();

            switch (userSelection)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    done = true;
                    break;
            }
        } while (!done);
    }
}