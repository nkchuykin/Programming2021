using System;

internal class Programmer
{
    private int GetAlmostRandomNumber()
    {
        return (int) Math.Abs(Math.Sin(GetIdDigitsSum() % 11 + 1) * 12345);
    }

    public Programmer(int id)
    {
        throw new NotImplementedException();
    }

    private int GetIdDigitsSum()
    {
        throw new NotImplementedException();
    }
}