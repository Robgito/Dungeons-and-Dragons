using Dungeons_and_Dragons.Dice;
using Dungeons_and_Dragons.Logger;
using Dungeons_and_Dragons.Player.Races;
using Dungeons_and_Dragons.Weapons;

namespace Dungeons_and_Dragons.Player
{
    public class PlayerFactory : IPlayerFactory
    {
        public Ilogger Logger { get; set; }
        public IWeaponFactory WeaponFactory { get; set; }
        public IDice Dice { get; set; }

        public PlayerFactory(IWeaponFactory weaponFactory, Ilogger logger, IDice dice)
        {
            Logger = logger;
            WeaponFactory = weaponFactory;
            Dice = dice;
        }

        public IPlayer Create(Race raceType)
        {
            switch (raceType)
            {
                case Race.Human:
                    return new Human(WeaponFactory, Logger, Dice);

                case Race.Elf:
                    return new Elf(WeaponFactory, Logger, Dice);

                case Race.Dwarf:
                    return new Dwarf(WeaponFactory, Logger, Dice);

                default:
                    throw new ArgumentException();
            }
        }
    }
}