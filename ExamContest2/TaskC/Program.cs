using System;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        double side = double.Parse(Console.ReadLine());
        Console.WriteLine(CircleInSquare.CircumFerence(side).ToString("f3"));
        Console.WriteLine(CircleInSquare.Square(side).ToString("f3"));
        Console.WriteLine(CircleInSquare.FreeSpace(side).ToString("f3"));
    }
}