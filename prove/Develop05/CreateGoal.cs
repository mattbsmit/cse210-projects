class CreateGoal
{
    protected string _goalType;
    private string _name;
    private string _description;
    private int _points;
    private bool _status;

    private string userInput;


    public CreateGoal(string goalType)
    {
        _goalType = goalType;
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