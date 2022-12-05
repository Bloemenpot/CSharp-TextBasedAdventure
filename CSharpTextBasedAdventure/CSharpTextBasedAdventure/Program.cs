namespace CSharpTextBasedAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            String playerChoise = "";
            String confirmChoise = "";

            Player.BaseCharacter();
            Console.WriteLine(Player.PlayerAttributes["level"].ToString());

            Console.WriteLine("This is what you say when you enter the world.");
            Console.WriteLine("First of all, let me ask you. What do you want you're name to be?");
            playerChoise = Console.ReadLine();
            Console.WriteLine("Are you sure you want this to be you're name: " + playerChoise + "\nY/N?");
            confirmChoise = Console.ReadLine();
            if (playerConfirm(confirmChoise))
            {
                Player.PlayerName = playerChoise;
            }
            else
                return;

            Console.Out.Flush();
            Console.Clear();

            Console.WriteLine("Next you will be able to choose the race of you're character.");
            Console.WriteLine("Human:\nAttack Damage: 4\nMaxHealth: 20\nDefence: 4\nAgility: 4\nLuck: 4\n");
            Console.WriteLine("Alien:\nAttack Damage: 3\nMaxHealth: 20\nDefence: 3\nAgility: 10\nLuck: 7\n");
            Console.WriteLine("Goblin:\nAttack Damage: 5\nMaxHealth: 20\nDefence: 5\nAgility: 2\nLuck: 3\n");
            Console.WriteLine("Human / Alien / Goblin");
            playerChoise = Console.ReadLine();
            Console.WriteLine("Are you sure you want this to be you're race: " + playerChoise + "\nY/N");
            confirmChoise = Console.ReadLine();
            if (playerConfirm(confirmChoise))
            {
                PlayerRaceSelection.PlayerRaceSelectionC(playerChoise);
            }
            else
                return;

            Console.Out.Flush();
            Console.Clear();

            Console.WriteLine("Last but not least, you get to choose the class of you're character.");
            Console.WriteLine("Warrior:\nAttackDamage: +2\nDefence: +2\nAgility: -1\n Luck: -1\n");
            Console.WriteLine("Wizard:\nAttackDamage: -2\nMaxHealth: +5\nDefence: +1\nAgility: -2\nLuck: +1\n");
            Console.WriteLine("Assassin:\nAttackDamage: -1\nAgility: +5\nLuck: +2\n");
            Console.WriteLine("Warrior / Wizard / Assassin");
            playerChoise = Console.ReadLine();
            Console.WriteLine("Are you sure you want this to be you're class: " + playerChoise + "\nY/N");
            confirmChoise = Console.ReadLine();
            if (playerConfirm(confirmChoise))
            {
                PlayerClassSelection.PlayerClassSelectionC(playerChoise);
            }
            else
                return;

            Console.Out.Flush();
            Console.Clear();

            Console.WriteLine(Player.PlayerAttributes["maxHealth"]);
        }

        public static bool playerConfirm(String input)
        {
            if (input.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
                return false;
        }

    }
}