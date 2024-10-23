using Dungeons_and_Dragons.Enemies;
using Dungeons_and_Dragons.Logger;
using Dungeons_and_Dragons.Player;

namespace Dungeons_and_Dragons
{
    public interface IGameLogic
    {
        public IPlayer Player { get; set; }
        IPlayerFactory PlayerFactory { get; set; }
        IEnemyFactory EnemyFactory { get; set; }
        Ilogger Logger { get; set; }
        int DefeatedEnemies { get; set; }
        int TotalDamageDealt { get; set; }

        void WeaponDrop(IEnemy enemy, IPlayer Player);

        IEnemy CreateRandomEnemy();

        void Encounter(IPlayer player);

        void PrintPlayerStats(IPlayer Player);

        IPlayer ChooseRace();

        void WelcomeMessage();

        void GameOver();
    }
}