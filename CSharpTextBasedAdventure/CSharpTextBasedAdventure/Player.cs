using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTextBasedAdventure
{
    internal class Player
    {
        //Base Attributes
        private static String playerName;
        private static String playerRace;
        private static String playerClass;

        //Attributes
        private static int exp = 0;
        private static int level = 1;
        private static int attackDamage = 0;
        private static int maxHealth = 0;
        private static int defence = 0;
        private static int agility = 0;
        private static int luck = 0;


        public static int Exp { get => exp; set => exp = value; }
        public static int Level { get => level; set => exp = value; } 
        public static string PlayerName { get => playerName; set => playerName = value; }
        public static string PlayerRace { get => playerRace; set => playerRace = value; }
        public static string PlayerClass { get => playerClass; set => playerClass = value; }
        public static int AttackDamage { get => attackDamage; set => attackDamage = value; }
        public static int MaxHealth { get => maxHealth; set => maxHealth = value; }
        public static int Defence { get => defence; set => defence = value; }
        public static int Agility { get => agility; set => agility = value; }
        public static int Luck { get => luck; set => luck = value; }
    }
}
