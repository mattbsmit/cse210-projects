class Lecture : Event
{
    private string _speaker;
    private int _capacity;


    public Lecture(string eventType, string title, string description, string date, string time, Address address, string speaker, int capacity)
    : base(eventType, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void FullDetails()
    {
        base.FullDetails();
        Console.WriteLine($"Speaker: {_speaker}\nCapacity: {_capacity}");
    }
}