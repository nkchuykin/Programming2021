using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] info = Console.ReadLine().Split();
        switch (info[0])
        {
            case "Soldier":
                var soldier = info[1] switch
                {
                    "Soldier" => new Soldier(),
                    "CoolerSoldier" => new CoolerSoldier(),
                    "ManInBlack" => new ManInBlack(),
                    "ManInBlackBoss" => new ManInBlackBoss()
                };
                Console.WriteLine(soldier.Attack());
                break;
            case "ManInBlack":
                var manInBlack = info[1] switch
                {
                    "ManInBlack" => new ManInBlack(),
                    "ManInBlackBoss" => new ManInBlackBoss()
                };
                Console.WriteLine(manInBlack.Attack());
                break;
        }
    }
}