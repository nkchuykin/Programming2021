using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        Hipster[] hipsters = new Hipster[n];
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            hipsters[i] = new Hipster(int.Parse(input[0]), int.Parse(input[1]));
        }

        try
        {
            Kikstarter kikstarter = new Kikstarter(m, hipsters);
            Console.WriteLine(kikstarter.Run());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}