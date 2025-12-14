using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        Running running = new Running(23, 14);
        Cycling cycling = new Cycling(47, 19);
        Swimming swimming= new Swimming(15, 27);

        activity.AddActivity(running.GetRun());
        activity.AddActivity(cycling.GetCycle());
        activity.AddActivity(swimming.GetSwim());

        activity.DisplayActivity();
    }
}