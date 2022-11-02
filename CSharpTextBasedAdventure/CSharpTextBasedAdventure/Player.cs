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
        private String playerName;
        private String playerRace;
        private PlayerClass playerClass;

        //Attributes
        private int attackDamage = 0;
        private int health = 0;
        private int defence = 0;
        private int agility = 0;
        private int luck = 0;

        public string PlayerName { get => playerName; set => playerName = value; }
        internal PlayerRace PlayerRace { get => playerRace; set => playerRace = value; }
        internal PlayerClass PlayerClass { get => playerClass; set => playerClass = value; }
        public int AttackDamage { get => attackDamage; set => attackDamage = value; }
        public int Health { get => health; set => health = value; }
        public int Defence { get => defence; set => defence = value; }
        public int Agility { get => agility; set => agility = value; }
        public int Luck { get => luck; set => luck = value; }
    }
}
