using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        Running running = new Running(30, 4);
        Cycling cycling = new Cycling(30, 12);
        Swimming swimming= new Swimming(30, 50);

        activity.AddActivity(running.GetRun());
        activity.AddActivity(swimming.GetSwim());
        activity.AddActivity(cycling.GetCycle());

        activity.DisplayActivity();
    }
}