using System;

internal partial class Program
{
    public static void Main(string[] args)
    {
        if (!int.TryParse(Console.ReadLine(), out int n) || !IsArrayLengthCorrect(n) || !TryReadArray(n, out int[] array))
        {
            Console.WriteLine("Incorrect input");
            return;
        }
        
        Console.WriteLine($"{AverageOfPositive(array):f3}");
    }
}