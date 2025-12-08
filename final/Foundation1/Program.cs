using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Video videoOne = new Video("I Tried Living Without Technology For 48 Hours", "NomadDave", 616);

        videoOne.GetComment("TechTom", "This actually inspired me to try a no-tech weekend myself!");
        videoOne.GetComment("LunaVibes", "The part where you reached for your phone out of habit was so relatable");
        videoOne.GetComment("GreenTrailGuy", "It’s crazy how peaceful things get once you unplug. Great video!");
        videoOne.DisplayVideo();
        videoOne.DisplayComments();
        Console.ReadLine();


        Console.Clear();
        Video videoTwo = new Video("Top 10 Space Facts You Never Heard", "CosmicCuriosity", 842);

        videoTwo.GetComment("StarChaser91", "I thought I knew a lot about space, but #4 blew my mind!");
        videoTwo.GetComment("NovaNotes", "Your explanations are so easy to follow. More space videos please!");
        videoTwo.GetComment("GalaxyGazer", "Can’t believe some of these facts aren’t more well-known. Awesome content.");
        videoTwo.DisplayVideo();
        videoTwo.DisplayComments(); 
        Console.ReadLine();


        Console.Clear();
        Video videoThree = new Video("Ultimate Guide to Making Perfect Homemade Ramen", "KitchenCraftKira", 503);

        videoThree.GetComment("FoodFanaticFelix", "Just tried this recipe—my ramen came out AMAZING!");
        videoThree.GetComment("NoodleNerd", "Love how you broke down each step. Super helpful!");
        videoThree.GetComment("ChefLyra", "The broth tips were spot on. Definitely saving this.");
        videoThree.DisplayVideo();
        videoThree.DisplayComments();
        Console.ReadLine();
    }
}