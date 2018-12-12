using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player = new Character(); //creating objects for character class and enemy class. Runs code in constructor
            Enemy enemy = new Enemy();  

            Console.WriteLine("Player Name: " + player.GetName()); // method calls to print player stats to user
            Console.WriteLine("Player Stats \nAttack: " + player.GetAttackStat());
            Console.WriteLine("Defense: " + player.GetDefenseStat());
            Console.WriteLine("Max Health: " + player.GetMaxHealthStat());
            Console.WriteLine("Current Health: " + player.GetHealthStat());

            Battle battle = new Battle(player,enemy); // sends reference* from enemy and player to be used in battle class

        }
    }
}
