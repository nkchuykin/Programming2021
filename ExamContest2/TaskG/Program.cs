using System;

internal class Program
{
    internal static void Main(string[] args)
    {
        BaseArray array = new ChristmasArray(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
        int number = int.Parse(Console.ReadLine());

        try
        {
            Console.WriteLine(array[number]);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine($"{array.GetMetric():f3}");
    }
}