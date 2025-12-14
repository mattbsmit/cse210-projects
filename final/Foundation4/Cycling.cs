class Cycling : Activity
{
    public Cycling(int duration, int speed)
    : base(duration)
    {
        _speed = speed;
        _activity = "Cycling";
    }


    public override void GetPace()
    {
        _pace = 60 / _speed;
    }

    public override void GetDistance()
    {
        _distance = _duration / _pace;
    }


    public string GetCycle()
    {
        GetPace();
        GetDistance();
        ActivitySummary();
        return _activitySummary;
    }
}