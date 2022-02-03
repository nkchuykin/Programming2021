using System;

internal class Shooter : Sportsman, IShooter
{
    public Shooter(int force, int agility, int endurance) : base(force, agility, endurance)
    {
    }

    int IShooter.Shoot()
    {
        return (int) (0.1 * Force + 0.8 * Agility + 0.1 * Endurance);
    }

    internal static Shooter Parse(string input)
    {
        try
        {
            int[] ints = Array.ConvertAll(input.Split(), int.Parse);
            if (ints.Length > 3)
            {
                throw new ArgumentException();
            }

            return new Shooter(ints[0], ints[1], ints[2]);
        }
        catch
        {
            throw new ArgumentException("Incorrect shooter");
        }
    }
}