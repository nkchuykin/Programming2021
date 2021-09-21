using System;

public partial class Program
{
    public static void Main(string[] args)
    {
        string dayOfWeek = Console.ReadLine();
        int firstNumberInput = int.Parse(Console.ReadLine());
        int secondNumberInput = int.Parse(Console.ReadLine());
        int result = MorningWorkout(dayOfWeek, firstNumberInput, secondNumberInput);
        
        Console.WriteLine(result >= 0 ? result.ToString() : "Incorrect input");
    }
}