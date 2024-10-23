using Dungeons_and_Dragons.Enemies;
using Dungeons_and_Dragons.Logger;
using Dungeons_and_Dragons.Player;
using Dungeons_and_Dragons.Player.Races;

namespace Dungeons_and_Dragons
{
    public class GameLogic : IGameLogic
    {
        public IPlayerFactory PlayerFactory { get; set; }
        public IPlayer Player { get; set; }
        public Ilogger Logger { get; set; }
        public IEnemyFactory EnemyFactory { get; set; }
        public int DefeatedEnemies { get; set; }
        public int TotalDamageDealt { get; set; }

        public GameLogic(IPlayerFactory playerFactory, Ilogger logger, IEnemyFactory enemyFactory)
        {
            PlayerFactory = playerFactory;
            Logger = logger;
            DefeatedEnemies = 0;
            EnemyFactory = enemyFactory;
        }

        public void Encounter(IPlayer Player)
        {
            while (Player.Health > 0)
            {
                IEnemy enemy = null;
                enemy = CreateRandomEnemy();
                Logger.PrintMessage("||| A new monster appeared! |||");
                Logger.PrintMessage($"Enemy HP: {enemy.Health}");
                Logger.PrintMessage("");
                Logger.Readinput();
                while (enemy.Health > 0)
                {
                    int damage = 0;
                    damage = Player.Attack();
                    enemy.TakeDamage(damage);
                    TotalDamageDealt += damage;
                    Logger.PrintMessage($"Enemy HP: {enemy.Health} |  Player HP: {Player.Health}");
                    Logger.Readinput();
                    if (enemy.Health <= 0)
                    {
                        Logger.PrintMessage("The enemy is dead!");
                        DefeatedEnemies++;
                        WeaponDrop(enemy, Player);
                        Logger.PrintMessage("");
                        break;
                    }
                    Player.TakeDamage(enemy.Attack());
                    Logger.PrintMessage($"Enemy HP: {enemy.Health} | Player HP: {Player.Health}");
                    Logger.Readinput();
                    if (Player.Health <= 0)
                    {
                        Logger.PrintMessage("You are dead!");
                        break;
                    }
                }
            }
        }

        public IEnemy CreateRandomEnemy()
        {
            IEnemyFactory enemyFactory = EnemyFactory;
            Random random = new Random();
            IEnemy enemy = null;
            int choice = random.Next(0, 3);
            EnemyTypes selectedEnemy = (EnemyTypes)choice;

            switch (selectedEnemy)
            {
                case EnemyTypes.Default:
                    enemy = enemyFactory.Create(EnemyTypes.Default);
                    break;

                case EnemyTypes.Critical:
                    enemy = enemyFactory.Create(EnemyTypes.Critical);
                    break;

                case EnemyTypes.Shield:
                    enemy = enemyFactory.Create(EnemyTypes.Shield);
                    break;
            }

            return enemy;
        }

        public void PrintPlayerStats(IPlayer Player)
        {
            Logger.PrintMessage("");
            Logger.PrintMessage($"You have chosen {Player.Race.ToString()}!");
            Logger.PrintMessage($"Here are your stats:");
            Logger.PrintMessage($"HP: {Player.Health}");
            Logger.PrintMessage($"Strength: {Player.Strength}");
            Logger.PrintMessage($"Intelligence: {Player.Intelligence}");
            Logger.PrintMessage($"Press ENTER to start.");
            Logger.Readinput();
        }

        public IPlayer ChooseRace()
        {
            int playerChoice = Convert.ToInt32(Logger.Readinput());
            Race selectedRace = (Race)playerChoice;
            IPlayer player = null;

            switch (selectedRace)
            {
                case Race.Human:
                    player = PlayerFactory.Create(Race.Human);
                    break;

                case Race.Dwarf:
                    player = PlayerFactory.Create(Race.Dwarf);
                    break;

                case Race.Elf:
                    player = PlayerFactory.Create(Race.Elf);
                    break;
            }
            return player;
        }

        public void WelcomeMessage()
        {
            Logger.PrintMessage("|=| WELCOME TO DUNGEONS AND DRAGONS! |=|");
            Logger.PrintMessage("");
            Logger.PrintMessage("Select the race you would like to play:");
            Logger.PrintMessage("1. Human");
            Logger.PrintMessage("2. Dwarf");
            Logger.PrintMessage("3. Elf");
        }

        public void WeaponDrop(IEnemy enemy, IPlayer Player)
        {
            Logger.PrintMessage($"It dropped a {enemy.DropWeapon.Name} ({enemy.DropWeapon.PrimairyAttr}: {enemy.DropWeapon.Damage} dmg), do you wish to pick it up? (y/n)");
            if (Logger.Readinput() == "y")
            {
                if (Player.Intelligence >= enemy.DropWeapon.MinIntelligence && Player.Strength >= enemy.DropWeapon.MinStrength)
                {
                    Player.Weapon = enemy.DropWeapon;
                    Logger.PrintMessage($"You picked up the {enemy.DropWeapon.Name}.");
                }
                else
                {
                    Logger.PrintMessage($"You do not meet the stat requirements to weild a {enemy.DropWeapon.Name}.");
                    Logger.PrintMessage($"You did not pick up the {enemy.DropWeapon.Name}.");
                }
            }
            else
            {
                Logger.PrintMessage($"You did not pick up the {enemy.DropWeapon.Name}.");
            }
            Logger.Readinput();
        }

        public void GameOver()
        {
            Logger.PrintMessage("Game Over!");
            Logger.PrintMessage("");
            Logger.PrintMessage($"Defeated enemies: {DefeatedEnemies}");
            Logger.PrintMessage($"Total damage dealt: {TotalDamageDealt}");
            Logger.Readinput();
        }
    }
}