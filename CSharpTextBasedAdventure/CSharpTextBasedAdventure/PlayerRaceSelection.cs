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

            if (selectedRace.Equals("human", StringComparison.OrdinalIgnoreCase))
            {
                Player.PlayerRace = "Human";
                Player.PlayerAttributes["attackDamage"] = currentAttack + 4;
                Player.PlayerAttributes["maxHealth"] = currentMaxHealth + 20;
                Player.PlayerAttributes["defence"] = currentDefence + 4;
                Player.PlayerAttributes["agility"] = currentAgility + 4;
                Player.PlayerAttributes["luck"] = currentLuck + 4;
            }
            if (selectedRace.Equals("alien", StringComparison.OrdinalIgnoreCase))
            {
                Player.PlayerRace = "Alien";
                Player.PlayerAttributes["attackDamage"] = currentAttack + 3;
                Player.PlayerAttributes["maxHealth"] = currentMaxHealth + 20;
                Player.PlayerAttributes["defence"] = currentDefence + 3;
                Player.PlayerAttributes["agility"] = currentAgility + 10;
                Player.PlayerAttributes["luck"] = currentLuck + 7;
            }
            if (selectedRace.Equals("goblin", StringComparison.OrdinalIgnoreCase))
            {
                Player.PlayerRace = "Goblin";
                Player.PlayerAttributes["attackDamage"] = currentAttack + 5;
                Player.PlayerAttributes["maxHealth"] = currentMaxHealth + 20;
                Player.PlayerAttributes["defence"] = currentDefence + 5;
                Player.PlayerAttributes["agility"] = currentAgility + 2;
                Player.PlayerAttributes["luck"] = currentLuck + 3;
            }
        }
    }
}
