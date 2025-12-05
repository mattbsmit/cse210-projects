class CheckList : CreateGoal
{
    public CheckList()
    : base("Checklist")
    {

    }

    public override void GoalInfo()
    {
        base.GoalInfo();

        Console.Write("How many times would you like to complete this goal: ");
        _completetions = int.Parse(Console.ReadLine());

        Console.Write("How many bonus points do you want for finishing the goal: ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override int RecordEvent()
    {
        return _points;
    }
}