using System;

public partial class Program
{
    public static void Main(string[] args)
    {
        var first = ParseInput(Console.ReadLine());
        var second = ParseInput(Console.ReadLine());
        
        Console.WriteLine(GetNumberOfEqualElements(first, second));
    }
}