class CreateGoal
{
    protected string _goalType;
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _status;
    protected int _completetions;
    protected int _bonusPoints;
    protected int _instances;

    private string userInput;


    public CreateGoal()
    {
        
    }

    public CreateGoal(string goalType)
    {
        _goalType = goalType;
    }

    public CreateGoal(string goalType, string name, string description, int points, bool status)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
        _status = status;
    }

    public CreateGoal(string goalType, string name, string description, int points, bool status, int completetions, int bonusPoints, int instances)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
        _status = status;
        _completetions = completetions;
        _bonusPoints = bonusPoints;
        _instances = instances;
    }

    public virtual void GoalInfo()
    {
        Console.Write("Enter goal name: ");
        _name = Console.ReadLine();

        Console.Write("Enter the goal description: ");
        _description = Console.ReadLine();

        Console.Write("Enter how many points this goal is worth: ");
        userInput = Console.ReadLine();
        _points = int.Parse(userInput);

        _status = false;
    }

    public virtual int RecordEvent()
    {
        _status = true;
        return _points;
    }

    public virtual string HumanString()
    {
        if (_status)
            return ($"[x] {_name} - {_description} - {_points}");
        else
            return ($"[ ] {_name} - {_description} - {_points}");
    }

    public virtual string CompString()
    {
        return ($"{_goalType}|{_name}|{_description}|{_points}|{_status}");
    }
}