class CreateGoal
{
    public string _name;
    public string _description;
    public int _points;
    public bool _status;
    public string _goalType;

    private string userInput;


    public CreateGoal()
    {
        _name = "";
        _description = "";
        _points = 0;
        _status = false;
        _goalType = "";
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

    public virtual void RecordEvent()
    {
        _status = true;
    }

    public virtual string GoalString()
    {
        return ($"Type: {_goalType} Name: {_name} Description: {_description} Points: {_points} Status: {_status}");
    }
}