using System;
using System.Collections.Generic;

internal partial class Program
{
    private static void Print(IEnumerable<int> arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
    
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        int[] sortedArr = StrangeSort(arr);
        
        Print(arr);
        Print(sortedArr);
    }
}