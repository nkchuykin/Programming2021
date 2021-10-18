using System;

internal partial class Program
{
    public static void Main(string[] args)
    {
        CountInFile("input.txt", out int countOfEvenLines, out int countOfOddWords);
        
        Console.WriteLine(countOfEvenLines);
        Console.WriteLine(countOfOddWords);
    }
}