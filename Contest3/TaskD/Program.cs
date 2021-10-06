using System;

public partial class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        if (!Validate(input, out int number))
        {
            Console.WriteLine("Incorrect input");
            return;
        }

        Console.WriteLine(RecurrentFunction(number));
    }
}