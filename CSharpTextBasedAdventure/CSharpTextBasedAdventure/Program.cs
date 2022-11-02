namespace CSharpTextBasedAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            String playerChoise = "";
            Console.WriteLine("Hello, World!");
            Console.WriteLine("This is what you say when you enter the world.");
            Console.WriteLine("But before you can start you have to choose what race and class you want to be!");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Out.Flush();
            Console.Clear();
            Console.WriteLine("You're choises for race are:");
            Console.WriteLine("Human:\n- Attack Damage: 4\n- Health: 20\n- Defence: 4\n- Agility = 4\n- Luck = 4\n\n");
            Console.WriteLine("Alien:\n- Attack Damage: 3\n- Health: 20\n- Defence: 3\n- Agility = 10\n- Luck = 7\n\n");
            Console.WriteLine("Goblin:\n- Attack Damage: 5\n- Health: 20\n- Defence: 5\n- Agility = 2\n- Luck = 3\n\n");
            Console.WriteLine("Type 1 of the above to choose its race (You can't change you're race after this!)");
            playerChoise = Console.ReadLine();
            playerChoise = playerChoise.ToLower();

            switch (playerChoise)
            {
                case "human":
                    Console.WriteLine("Are you sure you want to choose Human? y/n");
                    playerChoise = Console.ReadLine();
                    if (playerChoise.Equals("y"))
                    {
                        player.PlayerRace = ;
                    }
                    break;

                case "alien":
                    Console.WriteLine("Are you sure you want to choose Alien? y/n");
                    break;

                case "goblin":
                    Console.WriteLine("Are you sure you wnat to choose Goblin? y/n");
                    break;

                default:
                    Console.WriteLine("Please only choose between the above actions!");
                    break;
            }
        }
    }
}