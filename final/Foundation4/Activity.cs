using System.IO.Compression;

class Activity
{
    protected string _activity;
    protected int _distance;
    protected int _speed;
    protected int _pace;
    protected int _duration;
    protected int _laps;
    protected string _activitySummary;
    private string _date;


    List<string> Activities = new List<string>();


    public Activity()
    {
        
    }

    public Activity(int duration)
    {
        _duration = duration;
    }


    public virtual void GetDistance()
    {
        _distance = _laps * 50 / 1000;
    }

    public virtual void GetSpeed()
    {
        _speed = (_distance * _duration) / 60; 
    }

    public virtual void GetPace()
    {
        _pace = _duration / _distance;
    }


    public string ActivitySummary()
    {
        _date = DateTime.Now.ToString("dd MMM yyyy");
        _activitySummary = ($"{_date} {_activity} ({_duration} min.): Distance {_distance}, Speed {_speed} KPH, Pace {_pace} MPK");
        return _activitySummary;
    }

    public void AddActivity(string activity)
    {
        _activitySummary = activity;
        Activities.Add(_activitySummary);
    }

    public void DisplayActivity()
    {
        foreach (var i in Activities)
        {
            Console.WriteLine(i);
        }
    }
}