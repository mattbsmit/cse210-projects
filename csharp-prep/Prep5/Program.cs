using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = UserName();
        int number = UserNumber();
        int year = UserBirthYear();
        int squareNumber = SquareNumber(number);
        int age = GetAge(year);
        DisplayResult(name, squareNumber, age);

    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string UserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int UserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string enteredNumber = Console.ReadLine();
        int number = int.Parse(enteredNumber);
        return number;
    }
    static int UserBirthYear()
    {
        Console.Write("Please enter your birth year: ");
        string enteredYear = Console.ReadLine();
        int year = int.Parse(enteredYear);
        return year;
    }
    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }
    static int GetAge(int year)
    {
        int age = 2025 - year;
        return age;
    }
    static void DisplayResult(string name, int squaredNumber, int age)
    {
        Console.WriteLine($"{name}, your number squared is {squaredNumber}");
        Console.WriteLine($"{name} you will be turning {age} this year");
    }
}