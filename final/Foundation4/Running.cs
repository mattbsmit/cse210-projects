class Running : Activity
{
    public Running(int duration, int distance)
    : base(duration)
    {
        _distance = distance;
        _activity = "Running";
    }

    public string GetRun()
    {
        GetSpeed();
        GetPace();
        ActivitySummary();
        return _activitySummary;
    }
}