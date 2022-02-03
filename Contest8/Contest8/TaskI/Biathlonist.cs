using System;

internal class Biathlonist : Sportsman, ISkiRunner, IShooter
{
    public Biathlonist(int force, int agility, int endurance) : base(force, agility, endurance)
    {
    }

    int ISkiRunner.Run()
    {
        return (int) (0.5 * Force + 0.1 * Agility + 0.4 * Endurance);
    }

    int IShooter.Shoot()
    {
        return (int) (0.3 * Force + 0.4 * Agility + 0.3 * Endurance);
    }

    internal static Biathlonist Parse(string input)
    {
        try
        {
            int[] ints = Array.ConvertAll(input.Split(), int.Parse);
            if (ints.Length > 3)
            {
                throw new ArgumentException();
            }

            return new Biathlonist(ints[0], ints[1], ints[2]);
        }
        catch
        {
            throw new ArgumentException("Incorrect biathlonist");
        }
    }
}