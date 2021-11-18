using System;

internal class Soldier
{   
    public string Attack()
    {
        throw new NotImplementedException();
    }
}

internal sealed class CoolerSoldier : Soldier
{
    public string Attack()
    {
        throw new NotImplementedException();
    }
}

internal class ManInBlack : Soldier
{
    public string Attack()
    {
        throw new NotImplementedException();
    }
}

internal sealed class ManInBlackBoss : ManInBlack
{
    public string Attack()
    {
        throw new NotImplementedException();
    }
}