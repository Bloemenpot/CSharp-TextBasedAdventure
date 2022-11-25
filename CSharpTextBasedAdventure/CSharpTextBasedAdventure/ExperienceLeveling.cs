using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTextBasedAdventure
{
    internal class ExperienceLeveling
    {
        public static void Main(int gainedExp)
        {


            int currentExp = Player.Exp;
            currentExp += gainedExp;
            if (currentExp >= 100)
            {
                Player.Level += 1;
                LevelUp();
            }
            
        }

        static void LevelUp()
        {
            String playerChoise = "";
            Console.WriteLine("\n\nCongratulations! you leveled up to level: " + Player.Level + ".\nYou can choose a attribute to gain a higher value.\n\n");
            Console.WriteLine("Attack Damage: +1\nMaxHealth: +2\nDefence: +1\nAgility: +1\nLuck: +1\n");
            Console.WriteLine("Attack / MaxHealth / Defence / Agility / Luck");
            playerChoise = Console.ReadLine();
            if (playerChoise.Equals("attack", StringComparison.OrdinalIgnoreCase))
            {
                Player.AttackDamage += 1;
            } else if (playerChoise.Equals("maxHealth", StringComparison.OrdinalIgnoreCase))
            {
                Player.MaxHealth += 2;
            }
            else if (playerChoise.Equals("defence", StringComparison.OrdinalIgnoreCase))
            {
                Player.Defence += 1;
            }
            else if (playerChoise.Equals("agility", StringComparison.OrdinalIgnoreCase))
            {
                Player.Agility += 1;
            }
            else if (playerChoise.Equals("luck", StringComparison.OrdinalIgnoreCase))
            {
                Player.Luck += 1;
            }
            else
            {
                Console.Out.Flush();
                Console.Clear();
                Console.WriteLine("Please choose 1 of the 5 attributes to level up!");
                LevelUp();
            }
        }

    }
}
