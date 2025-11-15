using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string userSelection;
        bool done = false;

        Word myWord = new Word("Uncle");
        Reference reference = new Reference();
        Scripture scripture = new Scripture();

        Console.Clear();
        Console.WriteLine("What scripture would you like to memorize?");
        reference.DisplayList();

        Console.Write("Enter the number of the scripture you like to memorize: ");
        scripture.userScripture = int.Parse(Console.ReadLine());

        switch (scripture.userScripture)
        {
            case 1:
                Console.Clear();
                reference.ScriptureReference("John", 3, 16);
                break;
            case 2:
                Console.Clear();
                reference.ScriptureReference("Proverbs", 3, 5, 6);
                break;
        } while (!done)

        do
        {
            Console.WriteLine("Press enter to hid words or type 'q' to quit");
            userSelection = Console.ReadLine();
            switch (userSelection)
            {
                case "q":
                    done = true;
                    break;
                case "b":
                    break;
            }
        } while (!done);
    }
}