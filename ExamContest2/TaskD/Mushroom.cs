using System;
using System.Collections.Generic;

public class Mushroom
{
    private string Name { get; }
    private double Weight { get; }
    private double Diameter { get; }

    private Mushroom(string name, double weight, double diameter)
    {
        Name = name;
        Weight = weight;
        Diameter = diameter;
    }

    public static Mushroom Parse(string line)
    {
        throw new NotImplementedException();
    }

    public static double GetMinimalDiameter(List<Mushroom> mushrooms, double m)
    {
        throw new NotImplementedException();
    }
}