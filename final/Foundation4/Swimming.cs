class Swimming : Activity
{
    public Swimming(int duration, int laps)
    : base(duration)
    {
        _laps = laps;
        _activity  = "Swimming";
    }


    public string GetSwim()
    {
        GetDistance();
        GetSpeed();
        GetPace();
        ActivitySummary();
        return _activitySummary;
    }
}