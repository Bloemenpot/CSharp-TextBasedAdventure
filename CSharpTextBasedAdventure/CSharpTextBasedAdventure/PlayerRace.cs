using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTextBasedAdventure
{
    internal class PlayerRace
    {
        private static int attackDamage = 0;
        private static int health = 0;
        private static int defence = 0;
        private static int agility = 0;
        private static int luck = 0;

        public static int AttackDamage { get => attackDamage; set => attackDamage = value; }
        public static int Health { get => health; set => health = value; }
        public static int Defence { get => defence; set => defence = value; }
        public static int Agility { get => agility; set => agility = value; }
        public static int Luck { get => luck; set => luck = value; }

        public static void Human()
        {
            attackDamage = 4;
            health = 20;
            defence = 4;
            agility = 4;
            luck = 4;
        }

        public void Alien()
        {
            attackDamage = 3;
            health = 20;
            defence = 3;
            agility = 10;
            luck = 7;
        }

        public void Goblin()
        {
            attackDamage = 5;
            health = 20;
            defence = 5;
            agility = 2;
            luck = 3;
        }
    }
}
