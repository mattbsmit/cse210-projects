class Menu
{
    private int userInput;
    private string[] menuString =
    {
        "Menu Options:",
        "   1. Create New Goal",
        "   2. List Goals",
        "   3. Save Goals",
        "   4. Load Goals",
        "   5. Record Goal",
        "   6. Quit"
    };

    private string[] menuGoalString =
    {
       "What goal do you want to make?",
       "    1. Simple Goal",
       "    2. Eternal Goal",
       "    3. Checklist Goal" 
    };

    public int DisplayMenu()
    {
        userInput = 0;
        Console.Clear();
        do
        {
            foreach (string menuItem in menuString)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Select a choice from above: ");
            userInput = int.Parse(Console.ReadLine());
        } while (userInput < 1 || userInput > 6);

        return userInput;
    }
    public int DisplayGoalMenu()
    {
        userInput = 0;
        Console.Clear();

        do
        {
            foreach (string menuItem in menuGoalString)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Select a choice from above: ");
            userInput = int.Parse(Console.ReadLine());           
        } while (userInput < 1 || userInput > 4);

        return userInput;
    }
}