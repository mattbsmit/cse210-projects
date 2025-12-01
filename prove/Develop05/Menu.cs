class Menu
{
    private int userInput;
    private string[] MenuString =
    {
        "Menu Options:",
        "   1. Create New Goal",
        "   2. List Goals",
        "   3. Save Goals",
        "   4. Load Goals",
        "   5. Record Goal",
        "   6. Quit"
    };

    public int DisplayMenu()
    {
        userInput = 0;
        Console.Clear();
        do
        {
            foreach (string menuItem in MenuString)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Select a choice from above: ");
            userInput = int.Parse(Console.ReadLine());
        } while (userInput < 1 || userInput > 6);

        return userInput;
    }
}