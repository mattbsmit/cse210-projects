class CheckList : CreateGoal
{
    public CheckList()
    : base("Checklist")
    {

    }

    public override void GoalInfo()
    {
        base.GoalInfo();

        _completetions = 0;

        Console.Write("How many times would you like to complete this goal: ");
        _instances = int.Parse(Console.ReadLine());

        Console.Write("How many bonus points do you want for finishing the goal: ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override int RecordEvent()
    {
        _completetions += 1;

        if (_completetions == _instances)
        {
            _status = true;
            return _bonusPoints + _points;
        }

        else
        {
            return _points;
        }
            
    }

    public override string HumanString()
    {
        if (_status)
            return ($"[x] {_name} - {_description} - {_points} - {_bonusPoints} --> {_completetions}/{_instances}");
        else
            return ($"[ ] {_name} - {_description} - {_points} - {_bonusPoints} --> {_completetions}/{_instances}");
    }
}