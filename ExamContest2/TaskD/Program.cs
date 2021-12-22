using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());

        var mushrooms = new List<Mushroom>(n);

        for (int i = 0; i < n; i++)
        {
            try
            {
                mushrooms.Add(Mushroom.Parse(Console.ReadLine()));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        double minimum = Mushroom.GetMinimalDiameter(mushrooms, m);

        Console.WriteLine(minimum);
    }
}