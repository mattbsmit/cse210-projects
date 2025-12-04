using System;

class Program
{
    static void Main(string[] args)
    {
        int userSelection = 0;
        bool done = false;


        List<CreateGoal> _goals = new List<CreateGoal>();


        Menu menu = new Menu();
        GoalManager manager = new GoalManager();


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
                                _goals.Add(goal);
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

                    foreach (var g in _goals)
                    {
                        Console.WriteLine(g.HumanString());
                    }

                    Console.WriteLine("Press ENTER to continue:");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("What is the filename: ");
                    string userInput = Console.ReadLine();
                    //manager.SaveGoal(userInput);
                    break;
                case 4:
                    break;
                case 5:
                    int i = 1;

                    Console.Clear();

                    foreach (var g in _goals)
                    {
                        //Console.WriteLine($"    {i}. {g._name}");

                        i += 1;
                    }

                    Console.Write("What goal did you accomplish:");
                    int index = int.Parse(Console.ReadLine()) - 1;

                    _goals[index].RecordEvent();
                    break;
                case 6:
                    done = true;
                    break;
            }
        } while (!done);
    }
}