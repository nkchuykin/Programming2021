using System;

internal partial class Program
{
    // Объявление делегат-типа
    private delegate int SecondMaxDelegate(int[] arr);

    //Создание и инициализация экземпляра делегата
    private static readonly SecondMaxDelegate secondMax = SecondInArray;

    private static void Main(string[] args)
    {
        string[] stringArr = Console.ReadLine().Split();
        int[] arr = new int[stringArr.Length];
        
        for (int i = 0; i < stringArr.Length; i++)
        {
            arr[i] = int.Parse(stringArr[i]);
        }

        try
        {
            Console.WriteLine(secondMax(arr));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}