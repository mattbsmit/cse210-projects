using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        int userNumber;
        int sum = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        do
        {
            Console.Write("Enter a number: ");
            string enteredNumber = Console.ReadLine();
            userNumber = int.Parse(enteredNumber);
            
            list.Add(userNumber);
        } while (userNumber != 0);

        foreach (int item in list)
        {
            sum = sum + item;
        }

        int listSize = list.Count;
        int average = sum / listSize;
        int largeNumber = list.Max(); 

    
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largeNumber}");
    }
}