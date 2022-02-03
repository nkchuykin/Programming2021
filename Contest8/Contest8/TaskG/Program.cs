using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int countOfMonsters = int.Parse(Console.ReadLine());
        int castlePosition = int.Parse(Console.ReadLine());
        int MarioHP = int.Parse(Console.ReadLine());
        int MarioAttack = int.Parse(Console.ReadLine());
        int bossHP = int.Parse(Console.ReadLine());
        int bossAttack = int.Parse(Console.ReadLine());

        var game = new Game(
            castlePosition, 
            countOfMonsters,
            new Hero(MarioHP, MarioAttack),
            new Boss(bossHP, bossAttack)
        );

        for (int i = 0; i < countOfMonsters; i++)
        {
            int monsterHP = int.Parse(Console.ReadLine());
            int monsterAttack = int.Parse(Console.ReadLine());
            int monsterPosition = int.Parse(Console.ReadLine());
            var monster = new Monster(monsterHP, monsterAttack, monsterPosition);
            game.attackHero += monster.AttackHero;
        }

        game.Play();
    }
}