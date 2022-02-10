using System;

public delegate double Integral(double a, double b);

internal class Program
{
    public static Integral func;

    public static readonly double EPS = 10e-2;

    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            double[] args = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
            IntegralCalculator.InsertParameter((int) args[0]);
            Console.WriteLine(func(args[1], args[2]).ToString("f3"));
        }
    }
}