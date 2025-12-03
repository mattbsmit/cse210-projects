class CreateGoal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _status;
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
        Console.WriteLine("Enter goal name:");
        _name = Console.ReadLine();

        Console.WriteLine("Enter the goal description:");
        _description = Console.ReadLine();

        Console.WriteLine("Enter how many points this goal is worth:");
        userInput = Console.ReadLine();
        _points = int.Parse(userInput);

        _status = false;
    }

    public virtual string GoalString()
    {
        return ($"Type: {_goalType} Name: {_name} Description: {_description} Points: {_points} Status: {_status}");
    }
}