using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string valueInText = Console.ReadLine();
        int gradePercentage = int.Parse(valueInText);

        if (gradePercentage >= 90)
        {
            Console.WriteLine("Your letter grade is A");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Your letter grade is B");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Your letter grade is C");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Your letter grade is D");
        }
        else
        {
            Console.WriteLine("Your letter grade is F");
        }
    }
}