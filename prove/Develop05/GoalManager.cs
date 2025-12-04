using System.IO;
using System.Net.Http.Headers;


class GoalManager
{
    private string _fileName;
    private List<CreateGoal> _goals = new List<CreateGoal>(); 
    private int _totalScore;



    public GoalManager()
    {
        _totalScore = 0;
    }

    public void RecordEvent()
    {
        foreach (CreateGoal goal in _goals)
        {
            _totalScore += goal.RecordEvent();
        }
    }

    public void AddGoal(CreateGoal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.Clear();
        Console.WriteLine($"Total score is: {_totalScore}");
        Console.WriteLine("Current Goals: ");

        foreach (var g in _goals)
        {
            Console.WriteLine(g.HumanString());
        }

        Console.WriteLine("Press ENTER to continue:");
        Console.ReadLine();
    }

    public void GetFile()
    {
        Console.Clear();
        Console.Write("What is the filename: ");
        _fileName = Console.ReadLine();
    }

    public virtual void SaveGoal()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (CreateGoal goal in _goals)
            {
                outputFile.WriteLine(goal);
            }
        }
    }
}