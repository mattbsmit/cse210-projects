using System.Reflection;

class Event
{
    private string _eventType;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;


    public Event(string eventType, string title, string description, string date, string time, Address address)
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }


    public void StandardDetails()
    {
        Console.WriteLine($"Event: {_eventType}\n Title: {_title}\n Description: {_description}\n Date: {_date}\n Time: {_time}\n Address: {_address.FullAddress()}");
    }

    public virtual void FullDetails()
    {
        StandardDetails();
    }

    public void ShortDescription()
    {
        Console.WriteLine($"Event: {_eventType}\n Title: {_title}\n Date: {_date}");
    }
}