using System.IO;
using System.Net.Http.Headers;


class GoalManager
{
    private string _fileName;
    private List<CreateGoal> _goals = new List<CreateGoal>(); 
    private int _totalScore;
    private int _index = 1;



    public GoalManager()
    {
        _totalScore = 0;
    }

    public void RecordEvent()
    {
        Console.WriteLine("Here are your current goals:");

        foreach (CreateGoal goal in _goals)
        {
            Console.WriteLine($"    {_index}: {goal.HumanString()}");
            _index += 1;
        }
        Console.Write("Enter the number of the goal you finished: ");

        _index = int.Parse(Console.ReadLine()) - 1;
        _totalScore += _goals[_index].RecordEvent();
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

    public void SaveGoal()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (CreateGoal goal in _goals)
            {
                outputFile.WriteLine(goal.CompString());
            }
        }
    }
}