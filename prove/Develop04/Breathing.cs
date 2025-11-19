class Breathing : Activity
{
    private string stringLength;
    public Breathing()
    : base("Welcome to the breathing activity!\n", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n")
    {

    }
    private void BreathIn()
    {
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(5);
        stringLength = "";

        Console.Clear();
        Console.WriteLine("Breath In:");

        while (_startTime < _endTime)
        {
            Console.Write(">");
            Thread.Sleep(500);
            _startTime = DateTime.Now;
            stringLength += "<";
        }
    }
    
    private void BreathOut()
    {
        DateTime _startTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(5);

        Console.Clear();
        Console.WriteLine("Breath Out:");
        Console.Write(stringLength);

        while (_startTime < _endTime)
        {
            Console.Write(" \b\b");
            Thread.Sleep(500);
            _startTime = DateTime.Now;
        }
    }

    public void breathInOut()
    {
        DateTime timeSeconds = DateTime.Now;
        DateTime activityLength = timeSeconds.AddSeconds(_timeLength);

        Console.WriteLine(_timeLength);

        while (timeSeconds < activityLength)
        {
            BreathIn();
            BreathOut();
            timeSeconds = DateTime.Now;
        }
    }
}