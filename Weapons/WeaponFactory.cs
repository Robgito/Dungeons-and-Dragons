namespace Dungeons_and_Dragons.Weapons
{
    public class WeaponFactory : IWeaponFactory
    {
        public WeaponFactory()
        { }

        public IWeapon Create(WeaponType weaponType)
        {
            switch (weaponType)
            {
                case WeaponType.Sword:
                    return new Sword();

                case WeaponType.Club:
                    return new Club();

                case WeaponType.Bow:
                    return new Bow();

                case WeaponType.Wand:
                    return new Wand();

                case WeaponType.Spear:
                    return new Spear();

                case WeaponType.Dagger:
                    return new Dagger();

                default:
                    throw new ArgumentException();
            }
        }
    }
}