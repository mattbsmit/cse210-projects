using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Menu activityMenu = new Menu();
        Activity activity= new Activity();
        Breathing breathingActivity = new Breathing();
        Reflection reflectionActivity = new Reflection();
        Listening listeningActivity = new Listening();


        int userSelection = 0;
        bool done  = false;

        do
        {
            userSelection = activityMenu.DisplayMenu();

            switch (userSelection)
            {
                case 1:
                    breathingActivity.ShowActivity();
                    breathingActivity.GetTime();
                    breathingActivity.LoadingAnimation();
                    break;
                case 2:
                    reflectionActivity.ShowActivity();
                    reflectionActivity.GetTime();
                    reflectionActivity.LoadingAnimation();
                    break;
                case 3:
                    listeningActivity.ShowActivity();
                    listeningActivity.GetTime();
                    reflectionActivity.LoadingAnimation();
                    break;
                case 4:
                    done = true;
                    break;
            }
        } while (!done);
    }
}