using System;

class Program
{
    static void Main(string[] args)
    {
        int userSelection = 0;
        bool done = false;


        List<CreateGoal> goals = new List<CreateGoal>();


        Menu menu = new Menu();
        


        menu.DisplayMenu();


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
                                goals.Add(goal);
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
                    Console.Clear();
                    Console.WriteLine("Current Goals: ");

                    foreach (var g in goals)
                    {
                        Console.WriteLine(g.GoalString());
                    }

                    Console.WriteLine("Press ENTER to continue:");
                    Console.ReadLine();
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