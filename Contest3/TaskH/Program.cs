using System;

public partial class Program
{
    public static void Main(string[] args)
    {
        uint rowCount = uint.Parse(Console.ReadLine());
        PrintJaggedArray(GetBellTriangle(rowCount));
    }
}