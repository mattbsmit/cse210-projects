class Program
{
    static void passreftype(int [] data)
    {
        data[3] = 1234;
        Console.WriteLine($"data[3] is {data[3]}");
    }
        static void PassByOut(out int a)
    {
        a = 17;
        Console.WriteLine($"This is the pass by out of a {a}");
    }

    static void PassByValue(int x)
    {
        x = 2155;
        Console.WriteLine($"This is the pass by value of x {x}");
    }

    static void PassByRef(ref int x)
    {
        x = 1001;
        Console.WriteLine($"This is the pass by ref of x {x}");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        int x = 10;
        int y = x;

        y++;

        Console.WriteLine($"{x} {y}");

        int [] a = {1, 2, 3, 4, 5, 6};
        int [] b = a;

        b[3] = 111;
        Console.WriteLine($"{a[3]} {b[3]}");

        PassByValue(x);
        Console.WriteLine($"In main x is {x}");


        PassByRef(ref x);
        Console.WriteLine($"In main x is {x}");

        int z;
        PassByOut(out z);
        Console.WriteLine($"In main z is {z}");

        passreftype(a);
        Console.WriteLine($"in pass ref type a[3] is {a[3]}");
    }
}