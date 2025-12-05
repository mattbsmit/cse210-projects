using System.IO;
using System.Net.Http.Headers;
using System.Reflection.Metadata;


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
        Console.Clear();
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
            outputFile.WriteLine(_totalScore);
            
            foreach (CreateGoal goal in _goals)
            {
                outputFile.WriteLine(goal.CompString());
            }
        }
    }

    public virtual void LoadGoal()
    {
        string[] loadedGoals = System.IO.File.ReadAllLines(_fileName);

        _totalScore = int.Parse(loadedGoals[0]);

        foreach (string line in loadedGoals.Skip(1))
        {
            string[] parts = line.Split("|");

            string _goalType = parts[0];
            string _name = parts[1];
            string _description = parts[2];
            int _points = int.Parse(parts[3]);
            bool _status = bool.Parse(parts[4]);

            if (_goalType == "Checklist")
            {
                int _bonusPoints = int.Parse(parts[5]);
                int _completetions = int.Parse(parts[6]);
                int _instances = int.Parse(parts[7]);

                CreateGoal goal = new CreateGoal(_goalType, _name, _description, _points, _status, _completetions, _bonusPoints, _instances);
                AddGoal(goal);
            }

            else
            {
                CreateGoal goal = new CreateGoal(_goalType, _name, _description, _points, _status);
                AddGoal(goal);
            }
        }
    }
}