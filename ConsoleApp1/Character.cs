using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Character
    {
        private string name;
        private int attack;
        private int defense;
        private int health;
        private int maxHealth;


        public Character()
        {
            Console.WriteLine("Welcome To Game....");
            SetPlayerName();
            SetPlayerStats();
        }
        public String SetPlayerName()
        {
            Console.WriteLine("What is your name: ");
            name = Console.ReadLine();
            return name;
        }
        public void SetPlayerStats()
        {// Player stats will be on scale of 1 - 20 with starting chance to be as high as 5
            Random rnd = new Random();
            attack = rnd.Next(1, 6);
            defense = rnd.Next(1, 6);
            maxHealth = 100;
            health = 100;

        }
        public int SetPlayerHealth(int damage, int healing)
        {
            health = health - damage + healing;
            if (health > maxHealth)
            {
                health = maxHealth; // if health exceeds maxhealth set it to max health
            }

            return health;
        }
        public int GetAttackStat()
        {
            return attack;
        }
        public int GetDefenseStat()
        {
            return defense;
        }
        public int GetHealthStat()
        {
            return health;
        }
        public int GetMaxHealthStat()
        {
            return maxHealth;
        }
        public string GetName()
        {
            return name;
        }
    }
}
