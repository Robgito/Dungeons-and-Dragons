using Dungeons_and_Dragons.Weapons;

namespace Dungeons_and_Dragons.Enemies
{
    public interface IEnemy : ICombatUnit
    {
        int MinDamage { get; set; }
        int MaxDamage { get; set; }
        int Health { get; set; }
        IWeapon DropWeapon { get; set; }
        IWeaponFactory WeaponFactory { get; set; }

        void CreateDropWeapon();
    }
}