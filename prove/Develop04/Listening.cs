class Listening : Activity
{

    private string prompt;
    private int index;


    Random random = new Random();


    public Listening()
    : base("Welcome to the Listening Activity!\n", "This activity will help you reflect on the good things in , your life by having you list as many things as you can in a certain area.\n", "Listening Activity")
    {

    }

    new List<string> promptList = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    
    public void DisplayPrompt()
    {
        index = random.Next(promptList.Count);
        prompt = promptList[index];

        Console.Clear();
        Console.WriteLine(prompt);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_timeLength);

        while (startTime < endTime)
        {
            Console.Write("     - ");
            Console.ReadLine();

            startTime = DateTime.Now;
        }
    }
}