using System;

internal partial class Program
{
    public static void Main(string[] args)
    {
        string line = Console.ReadLine();
        ChangeCaseForLeastFrequentLetters(ref line);
        
        Console.WriteLine(line);
    }
}