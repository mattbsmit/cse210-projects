using System;

class Program
{
    static void Main(string[] args)
    {
        int userSelection = 0;
        bool done = false;


        Menu menu = new Menu();
        GoalManager manager = new GoalManager();


        do
        {         
            userSelection = menu.DisplayMenu();

            switch (userSelection)
            {
                case 1:
                    bool innerDone = false;

                    do 
                    {
                        userSelection = menu.DisplayGoalMenu();

                        switch (userSelection)
                        {
                            case 1:
                                CreateGoal goal = new Simple();
                                goal.GoalInfo();
                                manager.AddGoal(goal);
                                innerDone = true;
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                innerDone = true;
                                break;  
                        }            
                    } while (!innerDone);

                    done = false;
                    break;
                case 2:
                    manager.DisplayGoals();
                    break;
                case 3:
                    manager.GetFile();
                    manager.SaveGoal();
                    break;
                case 4:
                    manager.GetFile();
                    manager.LoadGoal();
                    break;
                case 5:
                    manager.RecordEvent();
                    break;
                case 6:
                    done = true;
                    break;
            }
        } while (!done);
    }
}