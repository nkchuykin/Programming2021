using System;

internal class Program
{
    private static void Main(string[] args)
    {
        var bfr = new BinaryFileReader("input.bin");
        Console.WriteLine(bfr.GetDifference());
    }
}