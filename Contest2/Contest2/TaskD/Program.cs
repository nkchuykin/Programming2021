using System;

public partial class Program
{
    public static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine(Max(a, b));
    }
}