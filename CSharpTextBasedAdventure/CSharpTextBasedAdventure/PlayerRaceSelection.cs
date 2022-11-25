using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTextBasedAdventure
{
    internal class PlayerRaceSelection
    {
        public static void PlayerRaceSelectionC(string selectedRace)
        {
            
            if(selectedRace.Equals("human", StringComparison.OrdinalIgnoreCase))
            {
                Player.PlayerRace = "Human";
                Player.AttackDamage = 4;
                Player.MaxHealth = 20;
                Player.Defence = 4;
                Player.Agility = 4;
                Player.Luck = 4;
            }
            if (selectedRace.Equals("alien", StringComparison.OrdinalIgnoreCase))
            {
                Player.PlayerRace = "Alien";
                Player.AttackDamage = 3;
                Player.MaxHealth = 20;
                Player.Defence = 3;
                Player.Agility = 10;
                Player.Luck = 7;
            }
            if (selectedRace.Equals("goblin", StringComparison.OrdinalIgnoreCase))
            {
                Player.PlayerRace = "Goblin";
                Player.AttackDamage = 5;
                Player.MaxHealth = 20;
                Player.Defence = 5;
                Player.Agility = 2;
                Player.Luck = 3;
            }
        }
    }
}
