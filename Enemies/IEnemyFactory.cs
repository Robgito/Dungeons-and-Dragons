using Dungeons_and_Dragons.Logger;
using Dungeons_and_Dragons.Weapons;

namespace Dungeons_and_Dragons.Enemies
{
    public interface IEnemyFactory
    {
        IEnemy Create(EnemyTypes enemyType);

        IWeaponFactory WeaponFactory { get; set; }
        Ilogger Logger { get; set; }
    }
}