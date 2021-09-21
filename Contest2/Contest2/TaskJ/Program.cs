using System;

public partial class Program
{
    public static void Main(string[] args)
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        if (!ValidateData(day, month, year))
        {
            Console.WriteLine("Incorrect input");
            return;
        }

        int dateOfWeek = GetDayOfWeek(day, month, year);

        string outputMessage = GetDateOfFriday(dateOfWeek, day, month, year);

        Console.WriteLine(outputMessage);
    }
}