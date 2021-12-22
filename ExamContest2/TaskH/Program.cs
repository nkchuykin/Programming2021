using System;

internal class Program
{
    private const string Path = "input.txt";
    
    private static void Main(string[] args)
    {
        string[] words = Reader.ReadFile(Path);
        Console.WriteLine(string.Join(" ", words));
    }
}