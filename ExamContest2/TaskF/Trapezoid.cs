using System;
using System.Collections.Generic;

internal class Trapezoid : GeometryRef
{
    public Trapezoid(List<Point> list) : base(list)
    {
    }

    protected double GetPerimeter()
    {
        throw new NotImplementedException();
    }

    public double GetSquare()
    {
        throw new NotImplementedException();
    }
}