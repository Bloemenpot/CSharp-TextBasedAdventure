using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTextBasedAdventure
{
    internal class PlayerClassSelection
    {
        public static void PlayerClassSelectionC(string selectedRace)
        {
            
            if(selectedRace.Equals("warrior", StringComparison.OrdinalIgnoreCase))
            {
                Player.PlayerClass = "Warrior";
                Player.AttackDamage += 2;
                Player.Defence += 2;
                Player.Agility -= 1;
                Player.Luck -= 1;
            }
            if (selectedRace.Equals("wizard", StringComparison.OrdinalIgnoreCase))
            {
                Player.PlayerRace = "Wizard";
                Player.AttackDamage -= 2;
                Player.MaxHealth += 5;
                Player.Defence += 1;
                Player.Agility -= 2;
                Player.Luck = +1;
            }
            if (selectedRace.Equals("assassin", StringComparison.OrdinalIgnoreCase))
            {
                Player.PlayerRace = "Assassin";
                Player.AttackDamage -= 1;
                Player.Agility += 5;
                Player.Luck += 2;
            }
        }
    }
}
