class CreateGoal
{
    private string _name;
    private string _description;
    private int _pointNumber;
    private bool _status;
    private string _goalType;


    public CreateGoal(string name, string description)
    {
        _name = name;
        _description = description;
        _pointNumber = 0;
        _status = false;
        _goalType = "";
    }

    public virtual string GetConsoleString()
    {
        return ($"Name: {_name}, Description: {_description}, Points: {_pointNumber}, Status: {_status}");
    }
}