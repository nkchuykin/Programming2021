using System;
using System.Collections.Generic;

internal class Program
{
    private static string GetForecasts(Citizen citizen)
    {
        return
            $"{((IPessimist) citizen).GetForecast():f3} {citizen.GetForecast():f3} {((IOptimist) citizen).GetForecast():f3}";
    }

    private static IEnumerable<Citizen> GetCitizens(int n)
    {
        var citizens = new List<Citizen>();
        for (int i = 0; i < n; i++)
        {
            citizens.Add(Citizen.Parse(Console.ReadLine()));
        }

        return citizens;
    }

    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        try
        {
            IEnumerable<Citizen> citizens = GetCitizens(n);
            foreach (var citizen in citizens)
            {
                Console.WriteLine(GetForecasts(citizen));
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}