using System;

public partial class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        if (Validate(n))
        {
            Console.WriteLine(GetPerfectNumber(n));
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }
    }
}