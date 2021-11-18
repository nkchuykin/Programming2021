using System;

internal sealed class Wizard : LegendaryHuman
{
    private string RankName;
    
    private int Rank { get; set; }

    public Wizard(string name, int healthPoints, int power, string rank)
    {
        throw new NotImplementedException();
    }

    public void Attack(LegendaryHuman enemy)
    {
        throw new NotImplementedException();
    }
}