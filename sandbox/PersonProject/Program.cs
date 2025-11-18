class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        Person myPerson = new Person("Obi Wan", "Kenobi", 34, 187);
        Console.WriteLine(myPerson.PersonInformation());


        Police myPolice = new Police("Taser, Flashlight", "Sally", "Jones", 27, 110);
        Console.WriteLine(myPolice.PoliceInformation());
    }
}