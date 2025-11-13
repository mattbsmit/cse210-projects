using System;

class Program
{
    static void Main(string[] args)
    {
        string userSelection;
        bool done = false;

        Console.WriteLine("Hello Develop03 World!");
        Word myWord = new Word("Uncle");
        myWord.DisplayWord();
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
                    done = true;
                    break;
            }
        } while (!done);
    }
}