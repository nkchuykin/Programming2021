internal abstract class Sportsman
{
    protected readonly int Force;
    protected readonly int Agility;
    protected readonly int Endurance;

    protected Sportsman(int force, int agility, int endurance)
    {
        Force = force;
        Agility = agility;
        Endurance = endurance;
    }
}