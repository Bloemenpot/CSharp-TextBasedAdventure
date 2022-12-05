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
            int currentAttack;
            int currentMaxHealth;
            int currentDefence;
            int currentAgility;
            int currentLuck;

            Player.PlayerAttributes.TryGetValue("attackDamage", out currentAttack);
            Player.PlayerAttributes.TryGetValue("maxHealth", out currentMaxHealth);
            Player.PlayerAttributes.TryGetValue("defence", out currentDefence);
            Player.PlayerAttributes.TryGetValue("agility", out currentAgility);
            Player.PlayerAttributes.TryGetValue("luck", out currentLuck);

            if (selectedRace.Equals("warrior", StringComparison.OrdinalIgnoreCase))
            {
                Player.PlayerClass = "Warrior";
                Player.PlayerAttributes["attackDamage"] = currentAttack + 2;
                Player.PlayerAttributes["defence"] = currentDefence + 2;
                Player.PlayerAttributes["agility"] = currentAgility - 1;
                Player.PlayerAttributes["luck"] = currentLuck - 1;
            }
            if (selectedRace.Equals("wizard", StringComparison.OrdinalIgnoreCase))
            {
                Player.PlayerRace = "Wizard";
                Player.PlayerAttributes["attackDamage"] = currentAttack - 2;
                Player.PlayerAttributes["maxHealth"] = currentMaxHealth + 5;
                Player.PlayerAttributes["defence"] = currentDefence + 1;
                Player.PlayerAttributes["agility"] = currentAgility - 2;
                Player.PlayerAttributes["luck"] = currentLuck + 1;
            }
            if (selectedRace.Equals("assassin", StringComparison.OrdinalIgnoreCase))
            {
                Player.PlayerRace = "Assassin";
                Player.PlayerAttributes["attackDamage"] = currentAttack - 1;
                Player.PlayerAttributes["agility"] = currentAgility + 5;
                Player.PlayerAttributes["luck"] = currentLuck + 2;
            }
        }
    }
}
