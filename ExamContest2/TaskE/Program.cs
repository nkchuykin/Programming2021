using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string type = Console.ReadLine();
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        var field = new Field(new int[width, height]);
        
        try
        {
            field.FillIn(type);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        Console.WriteLine(field);
    }
}