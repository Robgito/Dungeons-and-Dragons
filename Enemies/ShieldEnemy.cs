using Dungeons_and_Dragons.Logger;
using Dungeons_and_Dragons.Weapons;

namespace Dungeons_and_Dragons.Enemies
{
    public class ShieldEnemy : IEnemy
    {
        private Random random = new Random();

        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int Health { get; set; }
        public IWeapon DropWeapon { get; set; }
        public IWeaponFactory WeaponFactory { get; set; }
        public Ilogger Logger { get; set; }

        public ShieldEnemy(IWeaponFactory weaponFactory, Ilogger logger)
        {
            this.MinDamage = 0;
            this.MaxDamage = 4;
            this.Health = 50;
            Logger = logger;
            WeaponFactory = weaponFactory;
            CreateDropWeapon();
        }

        public int Attack()
        {
            int damage = random.Next(MinDamage, MaxDamage);
            Logger.PrintMessage($"The enemy attacks for {damage} damage!");
            return damage;
        }

        public void TakeDamage(int damage)
        {
            if (random.Next(1, 4) == 1) //25% block chance
            {
                damage = 0;
                Logger.PrintMessage("The enemy blocked the attack!");
            }
            Health -= damage;
        }

        public void CreateDropWeapon()
        {
            int randomChoice = random.Next(1, 6);
            WeaponType weaponType = (WeaponType)randomChoice;

            switch (weaponType)
            {
                case WeaponType.Sword:
                    DropWeapon = WeaponFactory.Create(WeaponType.Sword);
                    break;

                case WeaponType.Club:
                    DropWeapon = WeaponFactory.Create(WeaponType.Club);
                    break;

                case WeaponType.Bow:
                    DropWeapon = WeaponFactory.Create(WeaponType.Bow);
                    break;

                case WeaponType.Wand:
                    DropWeapon = WeaponFactory.Create(WeaponType.Wand);
                    break;

                case WeaponType.Spear:
                    DropWeapon = WeaponFactory.Create(WeaponType.Spear);
                    break;
            }
        }
    }
}