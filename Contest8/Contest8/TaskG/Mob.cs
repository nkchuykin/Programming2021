using System;

internal class Mob
{
    public int HP { get; set; }
    public int Attack { get; set; }

    public Mob(int hp, int attack)
    {
        throw new NotImplementedException();
    }

    public bool IsDead(Mob other)
    {
        throw new NotImplementedException();
    }

    public void AttackMob(Mob other)
    {
        throw new NotImplementedException();
    }
}