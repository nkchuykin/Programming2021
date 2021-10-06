using System;

public partial class Program
{
    public static void Main(string[] args)
    {
        var numberArray = ParseInput(Console.ReadLine());
        
        Console.WriteLine(GetMaxInArray(numberArray));
    }
}