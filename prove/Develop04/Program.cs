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
                    breathingActivity.breathInOut();
                    breathingActivity.ShowSummary();
                    break;
                case 2:
                    reflectionActivity.ShowActivity();
                    reflectionActivity.GetTime();
                    reflectionActivity.LoadingAnimation();
                    reflectionActivity.DisplayPrompt();
                    reflectionActivity.DisplayReflectPrompt();
                    reflectionActivity.ShowSummary();
                    break;
                case 3:
                    listeningActivity.ShowActivity();
                    listeningActivity.GetTime();
                    reflectionActivity.LoadingAnimation();

                    reflectionActivity.ShowSummary();
                    break;
                case 4:
                    done = true;
                    break;
            }
        } while (!done);
    }
}