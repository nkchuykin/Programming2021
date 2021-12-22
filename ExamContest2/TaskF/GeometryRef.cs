using System;
using System.Collections.Generic;

internal class GeometryRef
{
    protected List<Point> points;

    protected List<Point> Points
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    protected GeometryRef(List<Point> points)
    {
        throw new NotImplementedException();
    }

    protected double GetPerimeter()
    {
        throw new NotImplementedException();
    }

    public double GetSquare()
    {
        throw new NotImplementedException();
    }

    public static GeometryRef Parse(string line)
    {
        throw new NotImplementedException();
    }
}