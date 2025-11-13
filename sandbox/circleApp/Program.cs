class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Circle circle = new Circle();

        //._radius = 10;
        circle.SetRadius(10);
        Console.WriteLine(circle.GetArea());

        List<Circle> circles = new List<Circle>();
    }
}