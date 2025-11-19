using System.Security.Cryptography.X509Certificates;

class Activity
{
    private string _welcome;
    private string _summary;
    private int _timeLength;

    public Activity()
    {
        
    }
    public Activity(string welcome, string summary) //Removed timeLength since time should be passed down not up if time should be passed at all
    {
        _welcome = welcome;
        _summary = summary;
    }

    public void ShowActivity()
    {
        Console.Clear();
        Console.WriteLine(_welcome);
        Console.WriteLine(_summary);
    }

    public int GetTime()
    {
        Console.Write("How long in seconds would you like to practice this activity: ");
        string userLength = Console.ReadLine();
        _timeLength = int.Parse(userLength);

        return _timeLength;
    }

    private string Animation()
    {
        return "";
    }
}