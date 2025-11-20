class Reflection : Activity
{
    private string prompt;
    private string reflectPrompt;
    private int index;


    Random random = new Random();
    public Reflection()
    : base("Welcome to the Reflection Activity!\n", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n", "Reflection Activity")
    {

    }

    List<string> promptList = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    List<string> reflectList = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    
    public void DisplayPrompt()
    {
        index = random.Next(promptList.Count);
        prompt = promptList[index];

        Console.Clear();
        Console.WriteLine("Take some time to think about the following prompt...");
        Console.WriteLine($"    {prompt}\n");
        Console.Write("Press enter to continue...");
        Console.ReadLine();
    }

    public void DisplayReflectPrompt()
    {
        index = random.Next(reflectList.Count);
        reflectPrompt = reflectList[index];

        Console.Clear();
        Console.WriteLine("Now spend some time reflecting on these questions about the prompt:\n");
        Console.WriteLine($"    {reflectPrompt}");
        Thread.Sleep(TimeSpan.FromSeconds(_timeLength));
    }
}