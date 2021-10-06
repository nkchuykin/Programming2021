using System;

public partial class Program
{
    public static void Main(string[] args)
    {
        if (!TryParseInput(Console.ReadLine(), Console.ReadLine(), out var a, out var b))
        {
            Console.WriteLine("Incorrect input");
        }
        else
        {
            SwapMaxDigit(ref a, ref b);
            
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}