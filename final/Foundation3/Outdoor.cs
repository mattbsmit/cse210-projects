class Outdoor : Event
{
    private string _weather;


    public Outdoor(string eventType, string title, string description, string date, string time, Address address, string weather)
    : base(eventType, title, description, date, time, address)
    {
        _weather = weather;
    }


    public override void FullDetails()
    {
        base.FullDetails();
        Console.WriteLine($"Weather: {_weather}");
    }
}