using System;

internal partial class Program
{
    public static void Main(string[] args)
    {
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        Console.WriteLine(Count(array));
    }
}