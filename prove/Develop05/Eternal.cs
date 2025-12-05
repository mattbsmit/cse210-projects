class Eternal : CreateGoal
{
    public Eternal()
    : base("Eternal")
    {
    
    }

    public override int RecordEvent()
    {
        return _points;
    }
}