using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{/// <summary>
///  ideas list: enemy names can be like a random number that chooses a name from a string array and gets returned
///  random stats
///  ..
/// </summary>
    class Enemy
    {
        private string enName;
        private int attack;
        private int defense;
        private int health;

        public Enemy()
        {//method calls:
            SetEnemyName();
            SetEnemyStats();
        }
       
        public void SetEnemyName()
        {
            Random rnd = new Random();
            string[] enNameList = { "Rat", "Slime", "Goblin", "Car Salesman", "Incel", "Cat Lady", "Banana Monster", "Big Rat", "Malik", "Jordan" };
            enName = enNameList[rnd.Next(0, 10)]; // uses randomizer to choose index of array and sets to name
          
        }
        public void SetEnemyStats()
        {
            Random rnd = new Random();
            attack = rnd.Next(1, 4);
            defense = rnd.Next(1, 4);
            health = 100;
        }
        public int SetEnemyHealth(int damage, int healing)
        {
            health = health - damage + healing;
           

            return health;
        }
        public String GetEnemyName()
        {
            return enName;
        }
        public int GetEnemyAttackStat()
        {
            return attack;
        }
        public int GetEnemyDefenseStat()
        {
            return defense;
        }
        public int GetEnemyHealthStat()
        {
            return health;
        }
    }
}
