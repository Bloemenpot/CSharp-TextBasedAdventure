using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTextBasedAdventure
{
    internal class InBattle
    {
        public static void InBattleC()
        {
            Dictionary<string, int> playerStats = new Dictionary<string, int>();
            playerStats.Add("attackDamage", Player.AttackDamage);
        }
    }
}
