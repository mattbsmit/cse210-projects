class Reception : Event
{
    private string _name;
    private string _email;


    public Reception(string eventType, string title, string description, string date, string time, Address address, string name, string email)
    : base(eventType, title, description, date, time, address)
    {
        _name = name;
        _email = email;
    }

    public override void FullDetails()
    {
        base.FullDetails();
        Console.WriteLine($"Name: {_name}\nEmail: {_email}");
    }
}