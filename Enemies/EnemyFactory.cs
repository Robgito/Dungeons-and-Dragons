using Dungeons_and_Dragons.Logger;
using Dungeons_and_Dragons.Weapons;

namespace Dungeons_and_Dragons.Enemies
{
    public class EnemyFactory : IEnemyFactory
    {
        public IWeaponFactory WeaponFactory { get; set; }
        public Ilogger Logger { get; set; }

        public EnemyFactory(IWeaponFactory weaponFactory, Ilogger logger)
        {
            WeaponFactory = weaponFactory;
            Logger = logger;
        }

        public IEnemy Create(EnemyTypes enemyType)
        {
            switch (enemyType)
            {
                case EnemyTypes.Default:
                    return new DefaultEnemy(WeaponFactory, Logger);

                case EnemyTypes.Shield:
                    return new ShieldEnemy(WeaponFactory, Logger);

                case EnemyTypes.Critical:
                    return new CritEnemy(WeaponFactory, Logger);

                default:
                    throw new ArgumentException();
            }
        }
    }
}