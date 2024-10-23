namespace Dungeons_and_Dragons.Weapons
{
    public interface IWeaponFactory
    {
        IWeapon Create(WeaponType weaponType);
    }
}