using System;

class Program
{
    static void Main(string[] args)
    {
        int userSelection = 0;
        bool done = false;
        Menu menu = new Menu();
        CreateGoal createGoal = new CreateGoal("HELLO", "THERE");


        menu.DisplayMenu();
        menu.DisplayGoalMenu();


        do
        {         
            userSelection = menu.DisplayMenu();

            switch (userSelection)
            {
                case 1:
                    menu.DisplayGoalMenu();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    done = true;
                    break;
            }
        } while (!done);
    }
}