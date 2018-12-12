using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Battle
    {
        public Battle(Character player,Enemy enemy)
        {
            Console.WriteLine("");
            Console.WriteLine(enemy.GetEnemyName() + " appears and wants to do battle!\n\n");

            do // loop
            {
                enemy.SetEnemyHealth(player.GetAttackStat(), 0); //enemy health changes using player attack variable
                // message printed to user
                Console.WriteLine(player.GetName() + " attacks " + enemy.GetEnemyName() + " and does " + player.GetAttackStat() + " damage!");
                Console.WriteLine("Current Enemy Health: " + enemy.GetEnemyHealthStat()); // shows current health


                player.SetPlayerHealth(enemy.GetEnemyAttackStat(), 0); // player health chanegs based on enemy attack variable
                Console.WriteLine(enemy.GetEnemyName() + " attacks " + player.GetName() + " and does " + enemy.GetEnemyAttackStat() + " damage!");
                Console.WriteLine("Current Player Health: " + player.GetHealthStat());

            } while (player.GetHealthStat() > 0 && enemy.GetEnemyHealthStat() > 0);

            Console.WriteLine("Battle Over!");

        }
    }
}
