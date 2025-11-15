using System;

class Program
{
    static void Main(string[] args)
    {
        string userSelection;
        bool done = false;

        Word myWord = new Word("Uncle");
        Reference reference = new Reference();

        Console.WriteLine("What scripture would you like to memorize?");
        // print reference list here >>>> Console.WriteLine($"");

        do
        {
            Console.Clear();
            myWord.BuildVerse(reference.ScriptureReference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
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