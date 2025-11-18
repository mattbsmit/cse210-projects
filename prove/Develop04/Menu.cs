class Menu
{
    private int _userInput;
    private string[] _MenuString =
    {
        "Mindfulness Activity Options:",
        "   1. Breathing Activity",
        "   2. Relfection Activity",
        "   3. Listening Activity",
        "   4. Quit"
    };

    public int DisplayMenu()
    {
        _userInput = 0;
        do
        {
            foreach (string menuItem in _MenuString)
            {
                Console.WriteLine(menuItem);
            }
            Console.Write("Select a choice from above: ");
            _userInput = int.Parse(Console.ReadLine());
        } while (_userInput < 1 || _userInput > 4);

        return _userInput;
    }
}
